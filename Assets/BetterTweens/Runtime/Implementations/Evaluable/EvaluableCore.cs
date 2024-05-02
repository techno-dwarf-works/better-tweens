using System;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract partial class EvaluableCore : TweenCore
    {
        private const int ThresholdOverLoops = Data.LoopCount.MaxValue;

        [SerializeField] private SelectOverridableProperty<Ease> _ease;

        [Min(MinTime)]
        [SerializeField] private float _duration;

        [Min(MinTime)]
        [SerializeField] private float _startDelay;

        [Min(MinTime)]
        [SerializeField] private float _loopDelay;

        [SerializeField] private LoopMode _loopMode;

        private float _rawProgress;

        public float Duration => _duration;
        public float StartDelay => _startDelay;
        public float LoopDelay => _loopDelay;
        public float RemainingDelay { get; private set; }
        public bool InDelay => RemainingDelay > 0f;
        public float LoopProgress => _rawProgress % 1f;
        public float TotalProgress => _rawProgress / LoopCount;
        public Ease Ease => _ease.Value;
        public LoopMode LoopMode => _loopMode;
        public override int CompletedLoops => (int)_rawProgress;

        protected EvaluableCore()
        {
            _ease = new();
        }
    }
}