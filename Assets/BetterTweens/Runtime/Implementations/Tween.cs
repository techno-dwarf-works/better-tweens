using System;
using Better.Extensions.Runtime;
using Better.StateMachine.Runtime;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Tween
    {
        internal const float MaxProgress = 1f;

        [Min(default)]
        [SerializeField] private float _duration;

        private StateMachine<TweenState> _stateMachine;
        private PlayingTweenState _playingState;

        protected bool Initialized { get; private set; }
        public float Progress { get; internal set; }
        public float Duration => _duration;

        protected Tween(float duration)
        {
            _duration = duration;
        }

        #region Initialization

        protected internal void Initialize()
        {
            if (Initialized)
            {
                var message = "Already initialized";
                DebugUtility.LogException<InvalidOperationException>(message);
                return;
            }

            Initialized = true;
            _duration = Math.Max(_duration, default);
            _stateMachine = new();
            _playingState = new LinearPlayTweenState(this); // TODO

            _stateMachine.Run();
            var state = new StoppedState(this); // TODO
            _stateMachine.ChangeState(state);
        }

        protected internal void TryInitialize()
        {
            if (Initialized) return;

            Initialize();
        }

        #endregion

        public void Play()
        {
            TryInitialize();

            if (_stateMachine.InState<LinearPlayTweenState>())
            {
                return;
            }

            _stateMachine.ChangeState(_playingState);
            TweenRegistry.Register(this);
        }

        public void Rewing()
        {
            TryInitialize();

            if (_stateMachine.InState<RewindPlayTweenState>())
            {
                return;
            }

            var rewindState = new RewindPlayTweenState(this); // TODO
            _stateMachine.ChangeState(rewindState);
        }

        public void Pause()
        {
            TryInitialize();

            if (!IsPlaying())
            {
                return;
            }

            var pauseState = new PauseState(this);
            _stateMachine.ChangeState(pauseState);
        }

        public void Restart()
        {
            TryInitialize();
            Kill();
            Play();
        }

        internal void ApplyProgress(float value)
        {
            _stateMachine?.CurrentState.ApplyProgress(value);
        }

        internal abstract void ApplyState_Tween();

        public void Kill(bool isComplete = false)
        {
            TryInitialize();

            if (_stateMachine.InState<StoppedState>())
            {
                return;
            }

            if (isComplete)
            {
                if (!Mathf.Approximately(Progress, MaxProgress))
                {
                    Progress = MaxProgress;
                    ApplyState_Tween();
                }

                OnCompleted();
            }

            var stoppedState = new StoppedState(this);
            _stateMachine.ChangeState(stoppedState);

            TweenRegistry.Unregister(this);
            OnKilled();
        }

        protected abstract void OnCompleted();
        protected abstract void OnKilled();

        public bool IsPlaying()
        {
            TryInitialize();
            return _stateMachine.InState<PlayingTweenState>();
        }

        protected bool IsMutable()
        {
            TryInitialize();
            return _stateMachine.InState<StoppedState>();
        }

        protected internal bool ValidateMutable(bool targetState, bool logException = true)
        {
            var isMutable = IsMutable();
            var isValid = isMutable == targetState;
            if (!isValid && logException)
            {
                var reason = targetState ? "must be mutable" : "must be immutable";
                var message = "Not valid, " + reason;
                DebugUtility.LogException<InvalidOperationException>(message);
            }

            return isValid;
        }
    }
}