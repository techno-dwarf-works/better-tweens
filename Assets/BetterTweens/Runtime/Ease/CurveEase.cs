using System;
using Better.Tweens.Runtime.Logs;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CurveEase : Ease
    {
        [SerializeField] private AnimationCurve _source;

        public AnimationCurve Source => _source;

        public CurveEase(AnimationCurve source)
        {
            if (source == null)
            {
                var message = $"{nameof(source)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            _source = source;
        }

        public CurveEase() : this(AnimationCurve.Linear(0f, 0f, 1f, 1f))
        {
        }

        public override float Evaluate(float time)
        {
            return Source.Evaluate(time);
        }

        public override Ease Clone()
        {
            return new CurveEase(Source);
        }
    }
}