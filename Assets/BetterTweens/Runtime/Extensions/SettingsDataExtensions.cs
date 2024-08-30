using Better.Tweens.Runtime.Data;

namespace Better.Tweens.Runtime
{
    public static class SettingsDataExtensions
    {
        public static GlobalTimeScaleSettingsTween TweenGlobalTimeScale(this SettingsData self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<GlobalTimeScaleSettingsTween, SettingsData, float>(duration, options, optionsMode);
        }
    }
}