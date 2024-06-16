using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class InOutEase : Ease
    {
        [SerializeField] private EaseMode _mode;

        public EaseMode Mode
        {
            get => _mode;
            set => _mode = value;
        }

        protected InOutEase(EaseMode mode)
        {
            _mode = mode;
        }

        protected InOutEase() : this(EaseMode.InOut)
        {
        }

        public sealed override float Evaluate(float time)
        {
            return Mode switch
            {
                EaseMode.In => EvaluateIn(time),
                EaseMode.Out => EvaluateOut(time),
                EaseMode.InOut => EvaluateInOut(time),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        protected abstract float EvaluateIn(float time);

        private float EvaluateOut(float time)
        {
            return 1f - EvaluateIn(1f - time);
        }

        private float EvaluateInOut(float time)
        {
            if (time < 0.5f)
            {
                var inTime = time * 2f;
                return EvaluateIn(inTime) / 2f;
            }

            var outTime = Mathf.InverseLerp(0.5f, 1f, time);
            return 0.5f + EvaluateOut(outTime) / 2f;
        }
    }
}