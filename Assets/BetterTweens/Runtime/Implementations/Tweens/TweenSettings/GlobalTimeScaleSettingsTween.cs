using Better.Tweens.Runtime.Settings;

namespace Better.Tweens.Runtime
{
    public class GlobalTimeScaleSettingsTween : FloatTween
    {
        protected SettingsData SettingsData { get; private set; }

        protected internal override void OnStarted()
        {
            SettingsData = TweensSettings.Instance.Current;

            base.OnStarted();
        }

        protected override float GetCurrentValue()
        {
            return SettingsData.GlobalTimeScale;
        }

        protected override void SetCurrentValue(float value)
        {
            SettingsData.GlobalTimeScale = value;
        }
    }
}