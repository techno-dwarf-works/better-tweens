using System;
using System.Collections.Generic;
using Better.StateMachine.Runtime;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.States;
using Better.Tweens.Runtime.Triggers;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract partial class TweenCore
    {
        protected const float MinTime = 0f;
        private const int OverLoopsThreshold = Data.LoopCount.MaxValue;

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
        public event Action Broken;
        
        [Min(MinTime)]
        [SerializeField] private float _localTimeScale;
        [SerializeField] private LoopCount _loopCount;
        [SerializeField] private ValueOverridable<bool> _dependUnityTimeScale;
        [SerializeField] private ValueOverridable<bool> _dependGlobalTimeScale;
        [SerializeField] private SleepingDurationOverridable _sleepingDuration;
        [SerializeField] private ImplementationOverridable<TweenCoreAction> _completionAction;
        [SerializeField] private ImplementationOverridable<TweenCoreAction> _rewoundAction;

        private StateMachine<ActivityState> _activityMachine;
        private StateMachine<HandlingState> _handlingMachine;
        private HashSet<Trigger> _triggers;
        private HashSet<object> _tags;

        public int LoopCount => InfinityLoops ? CompletedLoops + 1 : _loopCount.Value;
        public bool InfinityLoops => _loopCount.Infinity;
        public bool DependUnityTimeScale => _dependUnityTimeScale.Value;
        public bool DependGlobalTimeScale => _dependGlobalTimeScale.Value;
        public float LocalTimeScale => _localTimeScale;
        public float SleepingDuration => _sleepingDuration.Duration;
        public bool InfinitySleeping => _sleepingDuration.Infinity;

        public virtual UpdateMode UpdateMode => UpdateMode.Update;
        public int CompletedLoops { get; private set; }

        protected bool Initialized { get; private set; }
        protected SettingsData SettingsData => TweensSettings.Instance.Current;
        private TweenCoreAction CompletionAction => _completionAction.Value;
        private TweenCoreAction RewoundAction => _rewoundAction.Value;

        protected TweenCore()
        {
            _localTimeScale = 1f;
            _loopCount = new();

            var defaultCompletionAction = SettingsData.CompletionAction.Clone();
            var defaultRewoundAction = SettingsData.RewoundAction.Clone();
            var defaultSleepingDuration = SettingsData.SleepingDuration.Clone();

            _dependUnityTimeScale = new(SettingsData.DependUnityTimeScale);
            _dependGlobalTimeScale = new(SettingsData.DependGlobalTimeScale);
            _sleepingDuration = new(defaultSleepingDuration);
            _completionAction = new(defaultCompletionAction);
            _rewoundAction = new(defaultRewoundAction);
        }
    }
}