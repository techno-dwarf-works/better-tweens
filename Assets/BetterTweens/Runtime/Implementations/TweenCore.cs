using System;
using Better.Extensions.Runtime;
using Better.StateMachine.Runtime;
using Better.Tweens.Runtime.Properties;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class TweenCore
    {
        private StateMachine<TweenState> _stateMachine;

        protected bool Initialized { get; private set; }
        protected internal abstract TweenProperties Properties { get; }

        internal float RawProgress { get; set; }
        public float Progress => RawProgress % 1f;
        public int CompletedLoops => (int)RawProgress;

        protected virtual UpdateMode UpdateMode => UpdateMode.Update;

        #region Initialization

        protected virtual void Initialize()
        {
            if (Initialized)
            {
                var message = "Already initialized";
                DebugUtility.LogException<InvalidOperationException>(message);
                return;
            }

            Initialized = true;
            _stateMachine = new();

            _stateMachine.Run();
            var state = new StoppedState(this); // TODO
            state.SuppressNextNotify();
            _stateMachine.ChangeState(state);
        }

        protected void TryInitialize()
        {
            if (Initialized) return;

            Initialize();
        }

        #endregion

        #region Controls

        public TweenCore Play()
        {
            TryInitialize();

            if (IsPlaying())
            {
                return this;
            }

            var isStart = IsStopped();

            var state = new PlayingState(this); // TODO
            _stateMachine.ChangeState(state);

            if (isStart)
            {
                OnStarted();
            }

            return this;
        }

        protected virtual void OnStarted()
        {
            Debug.Log("On Started"); // TODO
            // TODOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        }

        protected internal virtual void OnActive()
        {
            Debug.Log("On Active"); // TODO
        }

        protected internal virtual void OnPlay()
        {
            Debug.Log("On Play"); // TODO
        }

        public TweenCore Rewind()
        {
            TryInitialize();

            if (IsRewinding() || IsStopped())
            {
                return this;
            }

            var state = new RewindState(this); // TODO
            _stateMachine.ChangeState(state);

            return this;
        }

        protected internal virtual void OnRewind()
        {
            Debug.Log("On Rewind"); // TODO
        }

        public TweenCore Pause()
        {
            TryInitialize();

            if (!IsActive())
            {
                return this;
            }

            var pauseState = new PauseState(this);
            _stateMachine.ChangeState(pauseState);

            return this;
        }

        protected internal virtual void OnPause()
        {
            Debug.Log("On Paused"); // TODO
        }

        public TweenCore Restart()
        {
            Stop();
            Play();

            return this;
        }

        public TweenCore Stop()
        {
            TryInitialize();

            if (IsStopped())
            {
                return this;
            }

            var stoppedState = new StoppedState(this);
            _stateMachine.ChangeState(stoppedState);

            return this;
        }

        protected internal virtual void OnStopped()
        {
            Debug.Log("On Stopped"); // TODO
        }

        public void Complete()
        {
            if (!IsActive())
            {
                return;
            }

            // TODO validate (completed < loopCount ???)
            // TODO Add rewinding

            for (int i = CompletedLoops + 1; i <= Properties.LoopCount; i++)
            {
                RawProgress = i;
                OnLoopCompleted();
            }
        }

        protected virtual void OnCompleted()
        {
            Debug.Log("On Completed"); // TODO
            Stop();
        }

        #endregion

        #region Loops

        protected virtual void OnLoopCompleted()
        {
            // TODO: validate

            Debug.Log("OnLoop Completed"); // TODO
            if (CompletedLoops >= Properties.LoopCount)
            {
                OnCompleted();
            }
        }

        protected void OnLoopsCompleted(int count)
        {
            for (int i = 0; i < count; i++)
            {
                OnLoopCompleted();
            }
        }

        protected virtual void OnLoopRewound()
        {
            // TODO: validate

            Debug.Log("OnLoop Rewound"); // TODO
            if (CompletedLoops <= 0)
            {
                Pause();
            }
        }

        protected void OnLoopsRewound(int count)
        {
            for (int i = 0; i < count; i++)
            {
                OnLoopRewound();
            }
        }

        #endregion

        #region Progress

        internal void ApplyProgress(float value)
        {
            // TODO validate

            var rootCompletedLoops = CompletedLoops;
            var stateMod = _stateMachine.CurrentState.ProgressMod;
            var progressMod = Time.timeScale * stateMod / Properties.Duration; // TODO progress mod (time scale, etc)
            RawProgress += value * progressMod;
            RawProgress = Mathf.Clamp(RawProgress, default, Properties.LoopCount);

            if (CompletedLoops != rootCompletedLoops || (CompletedLoops == 0 && Mathf.Approximately(RawProgress, default)))
            {
                if (CompletedLoops > rootCompletedLoops)
                {
                    OnLoopsCompleted(CompletedLoops - rootCompletedLoops);
                }
                else
                {
                    var rewoundedLoops = Mathf.Max(rootCompletedLoops - CompletedLoops, 1);
                    OnLoopsRewound(rewoundedLoops);
                }

                if (!IsActive())
                {
                    return;
                }
            }

            // TODO
            var evaluatedTime = Properties.Mode switch
            {
                LoopMode.Restart or LoopMode.Incremental => Progress,
                LoopMode.PingPong => (CompletedLoops % 2 == 0) ? 1f - Progress : Progress,
                _ => throw new ArgumentOutOfRangeException(nameof(LoopMode))
            };

            ___Apply_Evaluate_STATE(evaluatedTime);
        }

        #endregion

        internal abstract void ___Apply_Evaluate_STATE(float time);

        #region Validation

        public bool IsActive()
        {
            TryInitialize();
            return _stateMachine.InState<ActiveState>();
        }

        public bool IsPlaying()
        {
            TryInitialize();
            return _stateMachine.InState<PlayingState>();
        }

        public bool IsRewinding()
        {
            TryInitialize();
            return _stateMachine.InState<RewindState>();
        }

        public bool IsPaused()
        {
            TryInitialize();
            return _stateMachine.InState<PauseState>();
        }

        public bool IsStopped()
        {
            TryInitialize();
            return _stateMachine.InState<StoppedState>();
        }

        protected bool IsMutable()
        {
            return IsStopped();
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

        #endregion
    }
}