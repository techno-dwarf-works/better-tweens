﻿using Better.Tweens.Runtime.Settings;

namespace Better.Tweens.Runtime
{
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