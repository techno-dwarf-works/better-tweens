namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        protected override void OnInitialized()
        {
            _ease.SetSource(SettingsData.Ease);

            base.OnInitialized();
        }
    }
}