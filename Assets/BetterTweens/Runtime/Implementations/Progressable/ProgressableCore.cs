using System;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract partial class ProgressableCore : TweenCore
    {
        private const float PlayingProgressMod = 1f;
        private const float RewindingProgressMod = -1f;

        [SerializeField] private ImplementationOverridable<Ease> _ease;

        [Min(TweensSettings.MinTime)]
        [SerializeField] private float _duration;

        [Min(TweensSettings.MinTime)]
        [SerializeField] private float _startDelay;

        [Min(TweensSettings.MinTime)]
        [SerializeField] private float _loopDelay;

        [SerializeField] private LoopMode _loopMode;

        private float _progressDirectionMod;

        public float Duration => _duration;
        public float StartDelay => _startDelay;
        public float LoopDelay => _loopDelay;
        public float LoopProgress { get; private set; }
        public float RemainingDelay { get; private set; }
        public bool InDelay => RemainingDelay > 0f;
        public Ease Ease => _ease.Value;
        public LoopMode LoopMode => _loopMode;

        protected ProgressableCore()
        {
            var defaultEase = SettingsData.Ease.Clone();
            _ease = new(defaultEase);
        }
    }
}