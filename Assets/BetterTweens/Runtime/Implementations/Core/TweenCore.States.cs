using Better.Tweens.Runtime.States;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        #region Activity

        public TweenCore Enable()
        {
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsEnabled())
            {
                return this;
            }

            var state = _activityStates.Get<EnabledState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnEnabled()
        {
            ActionUtility.Invoke(Enabled);
        }

        public TweenCore Sleep()
        {
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsSleeping())
            {
                return this;
            }

            var state = _activityStates.Get<SleepingState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnSleep()
        {
            ActionUtility.Invoke(Asleep);
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
            _rawProgress = default;
            RemainingDelay = StartDelay;

            _ease.SetSource(SettingsData.Ease);
            _dependUnityTimeScale.SetSource(SettingsData.DependUnityTimeScale);
            _dependGlobalTimeScale.SetSource(SettingsData.DependGlobalTimeScale);

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
            if (IsStopped())
            {
                return this;
            }

            var stoppedState = _handlingStates.Get<StoppedState>();
            _handlingMachine.ChangeState(stoppedState);

            return this;
        }

        protected internal virtual void OnStopped()
        {
            ActionUtility.Invoke(Stopped);
        }

        public TweenCore Complete()
        {
            if (IsCompleted())
            {
                return this;
            }

            for (int i = CompletedLoops + 1; i <= LoopCount; i++)
            {
                _rawProgress = i;
                OnLoopCompleted();
            }

            return this;
        }

        protected virtual void OnCompleted()
        {
            ActionUtility.Invoke(Completed);

            if (IsPlaying())
            {
                Stop();
            }
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