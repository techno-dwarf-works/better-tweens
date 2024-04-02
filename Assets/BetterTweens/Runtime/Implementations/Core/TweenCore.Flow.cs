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
            RemainingDelay = CoreProperties.StartDelay;

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
            if (!IsActive())
            {
                return this;
            }

            var pauseState = _statesCache.GetOrAdd<PauseState>();
            _stateMachine.ChangeState(pauseState);

            return this;
        }

        public TweenCore TogglePause()
        {
            if (IsPaused())
            {
                Play();
            }
            else if (IsActive())
            {
                Pause();
            }

            return this;
        }

        protected internal virtual void OnPaused()
        {
            CallbackUtility.InvokeWithSafety(Paused);
        }

        public TweenCore Stop()
        {
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
            if (IsStopped())
            {
                return this;
            }

            for (int i = CompletedLoops + 1; i <= CoreProperties.LoopCount; i++)
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
            Stop();
            Play();

            return this;
        }

        private void OnCachedState(TweenState state)
        {
            state.Setup(this);
        }
    }
}