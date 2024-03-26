using System;
using Better.Tweens.Runtime.Properties;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class TestTween : Tween<float>
    {
        private float objt;
        private float prevLog;

        public TestTween(float objt)
        {
            this.objt = objt;
        }

        internal override void ___Apply_Evaluate_STATE(float time)
        {
            if (Progress is > 0f and < 1f && Mathf.Abs(time - prevLog) < 0.1f) return;
            prevLog = time;

            var currentVal = Mathf.Lerp(FromValue, ToValue, time);
            Debug.Log($"apply: {currentVal}\n({FromValue}-{ToValue})\nRawProgress: {RawProgress}\nCompletedLoops: {CompletedLoops}");
        }

        protected override float GetCurrentValue()
        {
            return objt;
        }

        protected override float FindRelativeFrom(float to, float options)
        {
            return to - options;
        }

        protected override float FindTo(float from, float options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + Properties.Duration * options,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override float GetRelativeOptions(float from, float to)
        {
            return to - from;
        }
    }
}