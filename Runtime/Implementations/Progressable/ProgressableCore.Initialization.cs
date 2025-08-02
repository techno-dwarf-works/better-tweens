namespace Better.Tweens.Runtime
{
	public abstract partial class ProgressableCore
	{
		protected override void InitializeOverridableSources()
		{
			base.InitializeOverridableSources();

			_ease.SetSource(SettingsData.Ease);
		}
	}
}