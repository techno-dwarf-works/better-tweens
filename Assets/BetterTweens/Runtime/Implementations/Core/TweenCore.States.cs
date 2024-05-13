using Better.Tweens.Runtime.States;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        #region Activity

        public TweenCore Enable()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsEnabled())
            {
                return this;
            }

            var state = _activityStates.GetOrAdd<EnabledState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnEnabled()
        {
            ActionUtility.Invoke(Enabled);
        }

        public TweenCore Sleep()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsSleeping())
            {
                return this;
            }

            var state = _activityStates.GetOrAdd<SleepingState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnAsleep()
        {
            ActionUtility.Invoke(Asleep);
        }

        public TweenCore Disable()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsDisabled())
            {
                return this;
            }

            var state = _activityStates.GetOrAdd<DisabledState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnDisabled()
        {
            ActionUtility.Invoke(Disabled);
        }

        protected internal void OnActivityStateChanged(ActivityState state)
        {
            ActionUtility.Invoke(ActivityChanged);
            OnStateChanged();
        }

        private void OnActivityStateCached(ActivityState state)
        {
            state.Setup(this);
        }

        #endregion

        #region Handling

        public TweenCore Play()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsPlaying())
            {
                return this;
            }

            var state = _handlingStates.GetOrAdd<PlayingState>();
            if (IsStopped())
            {
                state.MarkStartTrigger();
            }

            _handlingMachine.ChangeState(state);
            return this;
        }

        protected internal virtual void OnStarted()
        {
            _dependUnityTimeScale.SetSource(SettingsData.DependUnityTimeScale);
            _dependGlobalTimeScale.SetSource(SettingsData.DependGlobalTimeScale);
            _sleepingDuration.SetSource(SettingsData.SleepingDuration);
            _completionAction.SetSource(SettingsData.CompletionAction);

            CompletedLoops = 0;

            ActionUtility.Invoke(Started);
        }

        protected internal virtual void OnRunned()
        {
            ActionUtility.Invoke(Runned);
        }

        protected internal virtual void OnPlay()
        {
            ActionUtility.Invoke(Playing);
        }

        public TweenCore Rewind()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsRewinding() || IsStopped())
            {
                return this;
            }

            var state = _handlingStates.GetOrAdd<RewindState>();
            _handlingMachine.ChangeState(state);

            return this;
        }

        protected internal virtual void OnRewind()
        {
            ActionUtility.Invoke(Rewinding);
        }

        public TweenCore Pause()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (!IsRunning())
            {
                return this;
            }

            var pauseState = _handlingStates.GetOrAdd<PauseState>();
            _handlingMachine.ChangeState(pauseState);

            return this;
        }

        public TweenCore TogglePause()
        {
            if (IsPaused())
            {
                Play();
            }
            else if (IsRunning())
            {
                Pause();
            }

            return this;
        }

        protected internal virtual void OnPaused()
        {
            ActionUtility.Invoke(Paused);
        }

        public TweenCore Stop()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsStopped())
            {
                return this;
            }

            var stoppedState = _handlingStates.GetOrAdd<StoppedState>();
            _handlingMachine.ChangeState(stoppedState);

            return this;
        }

        protected internal virtual void OnStopped()
        {
            ActionUtility.Invoke(Stopped);
        }

        public TweenCore ForceComplete()
        {
            if (IsCompletable())
            {
                return this;
            }

            // TODO: Test with infinity loops
            var loopCount = LoopCount - CompletedLoops;
            CompleteLoops(loopCount);
            return this;
        }

        protected virtual void OnCompleted()
        {
            var rootState = _handlingMachine.CurrentState;
            ActionUtility.Invoke(Completed);

            if (_handlingMachine.CurrentState == rootState)
            {
                if (CompletionAction.ReadinessFor(this))
                {
                    CompletionAction.Invoke(this);
                }
                else
                {
                    var message = $"{nameof(CompletionAction)} not readiness, will used {nameof(DefaultCompletionAction)}";
                    LogUtility.LogWarning(message);

                    DefaultCompletionAction.Invoke(this);
                }
            }
        }

        public TweenCore ForceRewound() // TODO: Instant or Force?
        {
            if (IsRewindable())
            {
                return this;
            }

            RewoundLoops(CompletedLoops);
            return this;
        }

        protected virtual void OnRewound()
        {
            ActionUtility.Invoke(Rewound);

            if (IsRewinding())
            {
                Pause();
            }
        }

        public TweenCore Restart()
        {
            Stop();
            Play();

            return this;
        }

        private void OnHandlingStateChanged(HandlingState state)
        {
            OnStateChanged();
        }

        private void OnHandlingStateCached(HandlingState state)
        {
            state.Setup(this);
        }

        #endregion

        protected virtual void OnStateChanged()
        {
            ActionUtility.Invoke(StateChanged);
        }
    }
}