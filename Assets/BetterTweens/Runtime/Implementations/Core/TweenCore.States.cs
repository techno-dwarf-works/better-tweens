﻿using System.Threading;
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

            var state = GetActivityState<SleepingState>();
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

            var state = GetActivityState<DisabledState>();
            _activityMachine.ChangeState(state);
            return this;
        }

        protected internal void OnDisabled()
        {
            ActionUtility.Invoke(Disabled);
        }

        private void OnActivityStateChanged(ActivityState state)
        {
            ActionUtility.Invoke(ActivityChanged);
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
            ActionUtility.Invoke(Rewinding);
        }

        public TweenCore Pause()
        {
            TryInitialize();
            if (!ValidateInitialized(true))
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
            ActionUtility.Invoke(Stopped);
        }

        public TweenCore InstantComplete()
        {
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

            ActionUtility.Invoke(Completed);
            if (rootStateToken.IsCancellationRequested)
            {
                return;
            }

            if (CompletionAction != null && CompletionAction.TryInvoke(this) && rootStateToken.IsCancellationRequested)
            {
                return;
            }

            var message = $"{nameof(CompletionAction)}({CompletionAction}) did not change state, will used {nameof(Stop)}";
            LogUtility.LogWarning(message);
            Stop();
        }

        public virtual TweenCore InstantRewound()
        {
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

            ActionUtility.Invoke(Rewound);
            if (rootStateToken.IsCancellationRequested)
            {
                return;
            }

            if (RewoundAction != null && RewoundAction.TryInvoke(this) && rootStateToken.IsCancellationRequested)
            {
                return;
            }

            var message = $"{nameof(RewoundAction)}({RewoundAction}) did not change state, will used {nameof(Pause)}";
            LogUtility.LogWarning(message);
            Pause();
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
            ActionUtility.Invoke(StateChanged);
        }

        private async void OnMachineOverflowed()
        {
            Disable();

            await _activityMachine.TransitionTask;
            await _handlingMachine.TransitionTask;
            await Task.Yield();

            var activityOverflowModule = _activityMachine.GetModule<ActivityState, StackOverflowModule<ActivityState>>();
            activityOverflowModule.Unlock();

            var handlingOverflowModule = _handlingMachine.GetModule<HandlingState, StackOverflowModule<HandlingState>>();
            handlingOverflowModule.Unlock();

            if (IsStopped())
            {
                return;
            }

            var message = $"States was stack overflowed, will be {nameof(Stop)}";
            LogUtility.LogWarning(message);
            Stop();
        }
    }
}