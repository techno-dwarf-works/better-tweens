using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class TimeScaleTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return Time.timeScale;
        }

        protected override void SetCurrentValue(float value)
        {
            Time.timeScale = value;
        }
    }
}