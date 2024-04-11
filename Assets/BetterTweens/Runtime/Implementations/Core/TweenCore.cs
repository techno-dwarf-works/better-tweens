using System;
using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Settings;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract partial class TweenCore
    {
        private const float MinDuration = 0f;
        private const float MinDelay = 0f;
        private const int MinLoopCount = 1;

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

        [Min(MinDuration)]
        [SerializeField] private float _duration;

        [Min(MinDelay)]
        [SerializeField] private float _startDelay;

        [Min(MinDelay)]
        [SerializeField] private float _loopDelay;

        [Min(MinLoopCount)]
        [SerializeField] private int _loopCount;

        [SerializeField] private LoopMode _loopMode;
        [SerializeField] private OverridableProperty<bool> _dependUnityTimeScale;
        [SerializeField] private OverridableProperty<bool> _dependGlobalTimeScale;
        [SerializeField] private float _localTimeScale;

        private StateMachine<TweenState> _stateMachine;
        private StatesCacheModule<TweenState> _statesCache;
        private float _rawProgress;

        public float Duration => _duration;
        public float StartDelay => _startDelay;
        public float LoopDelay => _loopDelay;
        public float RemainingDelay { get; private set; }
        public bool InDelay => RemainingDelay > 0f;
        public float LoopProgress => _rawProgress % 1f;
        public float TotalProgress => _rawProgress / LoopCount;
        public int LoopCount => _loopCount;
        public LoopMode LoopMode => _loopMode;
        public int CompletedLoops => (int)_rawProgress;
        public bool DependUnityTimeScale => _dependUnityTimeScale.Value;
        public bool DependGlobalTimeScale => _dependGlobalTimeScale.Value;
        public float LocalTimeScale => _localTimeScale;

        public virtual UpdateMode UpdateMode => UpdateMode.Update;

        protected bool Initialized { get; private set; }
        protected SettingsData SettingsData { get; private set; }

        protected TweenCore()
        {
            _loopCount = MinLoopCount;
            _dependUnityTimeScale = new();
            _dependGlobalTimeScale = new();
            _localTimeScale = 1f;
        }
    }
}