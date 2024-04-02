using System;
using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules;
using Better.Tweens.Runtime.Properties;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract partial class TweenCore
    {
        public event Action Started;
        public event Action Activated;
        public event Action Playing;
        public event Action Rewinding;
        public event Action Updated;
        public event Action Paused;
        public event Action Stopped;
        public event Action Completed;
        public event Action Rewound;
        public event Action LoopCompleted;
        public event Action LoopRewound;

        private StateMachine<TweenState> _stateMachine;
        private StatesCacheModule<TweenState> _statesCache;
        private float _rawProgress;

        public float Duration => CoreProperties.Duration;
        public float StartDelay => CoreProperties.StartDelay;
        public float LoopDelay => CoreProperties.LoopDelay;
        public float RemainingDelay { get; private set; }
        public bool InDelay => RemainingDelay > 0f;
        public float LoopProgress => _rawProgress % 1f;
        public float TotalProgress => _rawProgress / CoreProperties.LoopCount;
        public int LoopCount => CoreProperties.LoopCount;
        public LoopMode LoopMode => CoreProperties.LoopMode;
        public int CompletedLoops => (int)_rawProgress;
        public virtual UpdateMode UpdateMode => UpdateMode.Update;

        internal abstract CoreProperties CoreProperties { get; }

        protected bool Initialized { get; private set; }
    }
}