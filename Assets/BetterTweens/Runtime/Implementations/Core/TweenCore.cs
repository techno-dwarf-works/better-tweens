using System;
using System.Collections.Generic;
using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Settings;
using Better.Tweens.Runtime.States;
using Better.Tweens.Runtime.Triggers;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract partial class TweenCore
    {
        private const int ThresholdOverLoops = 1000000;
        private const float MinDuration = 0f;
        private const float MinDelay = 0f;

        public event Action StateChanged;
        public event Action ActivityChanged;
        public event Action Enabled;
        public event Action Asleep;
        public event Action Disabled;
        public event Action Started;
        public event Action Runned;
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

        [SerializeField] private LoopCount _loopCount;
        [SerializeField] private LoopMode _loopMode;
        [SerializeField] private OverridableProperty<Ease> _ease;
        [SerializeField] private OverridableProperty<bool> _dependUnityTimeScale;
        [SerializeField] private OverridableProperty<bool> _dependGlobalTimeScale;
        [SerializeField] private float _localTimeScale;
        [SerializeField] private SleepingDuration _sleepingDuration;

        private StateMachine<ActivityState> _activityMachine;
        private StatesCacheModule<ActivityState> _activityStates;
        private StateMachine<HandlingState> _handlingMachine;
        private StatesCacheModule<HandlingState> _handlingStates;
        private float _rawProgress;
        private HashSet<Trigger> _triggers;
        private HashSet<object> _tags;

        public float Duration => _duration;
        public float StartDelay => _startDelay;
        public float LoopDelay => _loopDelay;
        public float RemainingDelay { get; private set; }
        public bool InDelay => RemainingDelay > 0f;
        public float LoopProgress => _rawProgress % 1f;
        public float TotalProgress => _rawProgress / LoopCount;
        public int LoopCount => InfinityLoops ? CompletedLoops + 1 : _loopCount.Value;
        public bool InfinityLoops => _loopCount.Infinity;
        public LoopMode LoopMode => _loopMode;
        public int CompletedLoops => (int)_rawProgress;
        public Ease Ease => _ease.Value;
        public bool DependUnityTimeScale => _dependUnityTimeScale.Value;
        public bool DependGlobalTimeScale => _dependGlobalTimeScale.Value;
        public float LocalTimeScale => _localTimeScale;
        public float SleepingDuration => _sleepingDuration.Value;
        public bool InfinitySleeping => _sleepingDuration.Infinity;

        public virtual UpdateMode UpdateMode => UpdateMode.Update;

        protected bool Initialized { get; private set; }
        protected SettingsData SettingsData { get; private set; }

        protected TweenCore()
        {
            _loopCount = new();
            _ease = new();
            _dependUnityTimeScale = new();
            _dependGlobalTimeScale = new();
            _localTimeScale = 1f;
            _sleepingDuration = new();
        }
    }
}