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
        }

        protected internal virtual void OnActive()
        {
        }

        protected internal virtual void OnPlay()
        {
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

        protected internal virtual void OnPause()
        {
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
            Stop();
        }

        protected virtual void OnRewound()
        {
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