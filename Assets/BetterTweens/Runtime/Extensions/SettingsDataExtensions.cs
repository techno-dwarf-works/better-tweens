using Better.Tweens.Runtime.Settings;

namespace Better.Tweens.Runtime
{
    public static class SettingsDataExtensions
    {
        // Add Tweens for all extsns IEnumerable<>
        
        public static GlobalTimeScaleSettingsTween TweenGlobalTimeScale(this SettingsData self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<GlobalTimeScaleSettingsTween, SettingsData, float>(duration, options, optionsMode);
        }
    }
}