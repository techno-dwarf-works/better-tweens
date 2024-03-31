namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
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

            var state = _statesCache.GetOrAdd<PlayingState>();
            if (IsStopped())
            {
                state.MarkStartTrigger();
            }

            _stateMachine.ChangeState(state);
            return this;
        }

        protected internal virtual void OnStarted()
        {
            _rawProgress = default;
            RemainingDelay = DerivedProperties.StartDelay;

            CallbackUtility.InvokeWithSafety(Started);
        }

        protected internal virtual void OnActive()
        {
            CallbackUtility.InvokeWithSafety(Activated);
        }

        protected internal virtual void OnPlay()
        {
            CallbackUtility.InvokeWithSafety(Playing);
        }

        public TweenCore Rewind()
        {
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsRewinding() || IsStopped())
            {
                return this;
            }

            var state = _statesCache.GetOrAdd<RewindState>();
            _stateMachine.ChangeState(state);

            return this;
        }

        protected internal virtual void OnRewind()
        {
            CallbackUtility.InvokeWithSafety(Rewinding);
        }

        public TweenCore Pause()
        {
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (!IsActive())
            {
                return this;
            }

            var pauseState = _statesCache.GetOrAdd<PauseState>();
            _stateMachine.ChangeState(pauseState);

            return this;
        }

        protected internal virtual void OnPaused()
        {
            CallbackUtility.InvokeWithSafety(Paused);
        }

        public TweenCore Stop()
        {
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsStopped())
            {
                return this;
            }

            var stoppedState = _statesCache.GetOrAdd<StoppedState>();
            _stateMachine.ChangeState(stoppedState);

            return this;
        }

        protected internal virtual void OnStopped()
        {
            CallbackUtility.InvokeWithSafety(Stopped);
        }

        public TweenCore Complete()
        {
            if (!ValidateInitialized(true))
            {
                return this;
            }

            if (IsStopped())
            {
                return this;
            }

            for (int i = CompletedLoops + 1; i <= DerivedProperties.LoopCount; i++)
            {
                _rawProgress = i;
                OnLoopCompleted();
            }

            return this;
        }

        protected virtual void OnCompleted()
        {
            CallbackUtility.InvokeWithSafety(Completed);
            Stop();
        }

        protected virtual void OnRewound()
        {
            CallbackUtility.InvokeWithSafety(Rewound);
            Pause();
        }

        public TweenCore Restart()
        {
            if (ValidateInitialized(true))
            {
                Stop();
                Play();
            }

            return this;
        }

        private void OnCachedState(TweenState state)
        {
            state.Setup(this);
        }
    }
}