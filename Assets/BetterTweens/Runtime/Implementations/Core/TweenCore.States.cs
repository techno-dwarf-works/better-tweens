using System.Threading;
using System.Threading.Tasks;
using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules;
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

            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (IsEnabled())
            {
                return this;
            }

            var state = GetActivityState<EnabledState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnEnabled()
        {
            ActionUtility.TryInvokeBySafe(Enabled);
        }

        public TweenCore Sleep()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (IsSleeping())
            {
                return this;
            }

            var state = GetActivityState<SleepingState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnAsleep()
        {
            ActionUtility.TryInvokeBySafe(Asleep);
        }

        public TweenCore Disable()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (IsDisabled())
            {
                return this;
            }

            var state = GetActivityState<DisabledState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnDisabled()
        {
            ActionUtility.TryInvokeBySafe(Disabled);
        }

        private void OnActivityStateChanged(ActivityState state)
        {
            ActionUtility.TryInvokeBySafe(ActivityChanged);
            OnStateChanged();
        }

        private void OnActivityStateCached(ActivityState state)
        {
            state.Setup(this);
        }

        private TState GetActivityState<TState>()
            where TState : ActivityState, new()
        {
            var module = _activityMachine.GetModule<ActivityState, CacheModule<ActivityState>>();
            return module.GetOrAddState<TState>();
        }

        protected CancellationToken GetActivityStateToken()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return CancellationToken.None;
            }

            return _activityMachine.CurrentState.Token;
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

            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (IsPlaying() || !IsPlayable())
            {
                return this;
            }

            var state = GetHandlingState<PlayingState>();
            if (IsStopped())
            {
                state.MarkStartTrigger();
            }

            _handlingMachine.ChangeState(state);
            return this;
        }

        protected internal virtual void OnStarted()
        {
            CompletedLoops = 0;
            ActionUtility.TryInvokeBySafe(Started);
        }

        protected internal virtual void OnRunned()
        {
            ActionUtility.TryInvokeBySafe(Runned);
        }

        protected internal virtual void OnPlay()
        {
            ActionUtility.TryInvokeBySafe(Playing);
        }

        public TweenCore Rewind()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (IsRewinding() || !IsRewindable())
            {
                return this;
            }

            var state = GetHandlingState<RewindState>();
            _handlingMachine.ChangeState(state);

            return this;
        }

        protected internal virtual void OnRewind()
        {
            ActionUtility.TryInvokeBySafe(Rewinding);
        }

        public TweenCore Pause()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (IsPaused() || !IsPausable())
            {
                return this;
            }

            var pauseState = GetHandlingState<PauseState>();
            _handlingMachine.ChangeState(pauseState);

            return this;
        }

        public TweenCore TogglePause()
        {
            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

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
            ActionUtility.TryInvokeBySafe(Paused);
        }

        public TweenCore Stop()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (IsStopped() || !IsStoppable())
            {
                return this;
            }

            var stoppedState = GetHandlingState<StoppedState>();
            _handlingMachine.ChangeState(stoppedState);

            return this;
        }

        protected internal virtual void OnStopped()
        {
            ActionUtility.TryInvokeBySafe(Stopped);
        }

        public TweenCore InstantComplete()
        {
            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (!IsCompletable())
            {
                return this;
            }

            var rootStateToken = GetHandlingStateToken();
            var loopCount = LoopCount - CompletedLoops;
            InstantCompleteLoops(loopCount);

            if (InfinityLoops && !rootStateToken.IsCancellationRequested)
            {
                OnCompleted();
            }

            return this;
        }

        protected virtual void OnCompleted()
        {
            var rootStateToken = GetHandlingStateToken();

            ActionUtility.TryInvokeBySafe(Completed);
            if (rootStateToken.IsCancellationRequested)
            {
                return;
            }

            if (CompletionAction != null && CompletionAction.TryInvoke(this) && rootStateToken.IsCancellationRequested)
            {
                return;
            }

            var message = $"{nameof(CompletionAction)}({CompletionAction}) did not change state, will used {nameof(Stop)}";
            LogUtility.LogWarning(message, this);
            Stop();
        }

        public virtual TweenCore InstantRewound()
        {
            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

            if (!IsRewindable())
            {
                return this;
            }

            InstantRewoundLoops(CompletedLoops + 1);
            return this;
        }

        protected virtual void OnRewound()
        {
            var rootStateToken = GetHandlingStateToken();

            ActionUtility.TryInvokeBySafe(Rewound);
            if (rootStateToken.IsCancellationRequested)
            {
                return;
            }

            if (RewoundAction != null && RewoundAction.TryInvoke(this) && rootStateToken.IsCancellationRequested)
            {
                return;
            }

            var message = $"{nameof(RewoundAction)}({RewoundAction}) did not change state, will used {nameof(Pause)}";
            LogUtility.LogWarning(message, this);
            Pause();
        }

        public TweenCore Restart()
        {
            if (TryHandleBroken() && !ValidateBroken(false))
            {
                return this;
            }

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

        private TState GetHandlingState<TState>()
            where TState : HandlingState, new()
        {
            var module = _handlingMachine.GetModule<HandlingState, CacheModule<HandlingState>>();
            return module.GetOrAddState<TState>();
        }

        protected CancellationToken GetHandlingStateToken()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
            {
                return CancellationToken.None;
            }

            return _handlingMachine.CurrentState.Token;
        }

        #endregion

        protected virtual void OnStateChanged()
        {
            ActionUtility.TryInvokeBySafe(StateChanged);
        }

        private async void OnMachineOverflowed()
        {
            await _activityMachine.TransitionTask;
            await _handlingMachine.TransitionTask;
            await Task.Yield();

            var activityOverflowModule = _activityMachine.GetModule<ActivityState, StackOverflowModule<ActivityState>>();
            activityOverflowModule.Unlock();

            var handlingOverflowModule = _handlingMachine.GetModule<HandlingState, StackOverflowModule<HandlingState>>();
            handlingOverflowModule.Unlock();

            var message = $"States was stack overflowed, will be {nameof(Disable)}";
            LogUtility.LogWarning(message, this);
            Disable();
        }

        private void HandleBroken()
        {
            var warningMessage = $"State is broken, will be {nameof(Disable)}";
            LogUtility.LogWarning(warningMessage, this);

            Disable();
            OnBrokenHandled();
        }

        private bool TryHandleBroken()
        {
            if (IsBroken())
            {
                HandleBroken();
                return true;
            }

            return false;
        }

        protected virtual void OnBrokenHandled()
        {
            ActionUtility.TryInvokeBySafe(Broken);
        }
    }
}