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

        public float Duration => DerivedProperties.Duration;
        public float StartDelay => DerivedProperties.StartDelay;
        public float LoopDelay => DerivedProperties.LoopDelay;
        public float RemainingDelay { get; private set; }
        public bool InDelay => RemainingDelay > 0f;
        public float LoopProgress => _rawProgress % 1f;
        public float TotalProgress => _rawProgress / DerivedProperties.LoopCount;
        public int LoopCount => DerivedProperties.LoopCount;
        public LoopMode LoopMode => DerivedProperties.LoopMode;
        public int CompletedLoops => (int)_rawProgress;
        public virtual UpdateMode UpdateMode => UpdateMode.Update;

        internal abstract TweenProperties DerivedProperties { get; }

        protected bool Initialized { get; private set; }
    }
}