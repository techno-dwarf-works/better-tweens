using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LocalTimeScaleCoreTween : FloatTween<TweenCore>
    {
        protected override float GetCurrentValue()
        {
            return Target.LocalTimeScale;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.SetLocalTimeScale(value);
        }
    }
}