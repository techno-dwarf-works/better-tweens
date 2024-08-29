using System;
using Better.Tweens.Runtime.Data;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class GlobalTimeScaleSettingsTween : FloatTween<SettingsData>
    {
        protected override float GetCurrentValue()
        {
            return Target.GlobalTimeScale;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.GlobalTimeScale = value;
        }
    }
}