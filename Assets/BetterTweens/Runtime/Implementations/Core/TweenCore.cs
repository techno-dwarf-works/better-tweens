using System;
using System.Collections.Generic;
using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules;
using Better.Tweens.Runtime.Actions;
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
        protected const float MinTime = 0f;
        
        public static readonly TweenCoreAction DefaultCompletionAction = StopAction.Instance;

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

        [SerializeField] private LoopCount _loopCount;
        [SerializeField] private float _localTimeScale;
        [SerializeField] private NaturalOverridableProperty<bool> _dependUnityTimeScale;
        [SerializeField] private NaturalOverridableProperty<bool> _dependGlobalTimeScale;
        [SerializeField] private NaturalOverridableProperty<SleepingDuration> _sleepingDuration;
        [SerializeField] private SelectOverridableProperty<TweenCoreAction> _completionAction; // TODO: Add for rewound

        private StateMachine<ActivityState> _activityMachine;
        private StatesCacheModule<ActivityState> _activityStates;
        private StateMachine<HandlingState> _handlingMachine;
        private StatesCacheModule<HandlingState> _handlingStates;
        private HashSet<Trigger> _triggers;
        private HashSet<object> _tags;

        public int LoopCount => InfinityLoops ? CompletedLoops + 1 : _loopCount.Value;
        public bool InfinityLoops => _loopCount.Infinity;
        public bool DependUnityTimeScale => _dependUnityTimeScale.Value;
        public bool DependGlobalTimeScale => _dependGlobalTimeScale.Value;
        public float LocalTimeScale => _localTimeScale;
        public float SleepingDuration => _sleepingDuration.Value.Value;
        public bool InfinitySleeping => _sleepingDuration.Value.Infinity;
        private TweenCoreAction CompletionAction => _completionAction.Value;

        public virtual UpdateMode UpdateMode => UpdateMode.Update;
        public int CompletedLoops { get; private set; }

        protected bool Initialized { get; private set; }
        protected SettingsData SettingsData { get; private set; }

        protected TweenCore()
        {
            _localTimeScale = 1f;
            _loopCount = new();
            _sleepingDuration = new();
            // TODO: default overridable value
            _dependUnityTimeScale = new();
            _dependGlobalTimeScale = new();
            _completionAction = new();
        }
    }
}