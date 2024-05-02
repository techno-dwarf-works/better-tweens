namespace Better.Tweens.Runtime
{
    public abstract partial class EvaluableCore
    {
        protected internal override void OnStarted()
        {
            _rawProgress = 0f;
            _ease.SetSource(SettingsData.Ease);
            RemainingDelay = StartDelay;
            
            base.OnStarted();
        }

        protected override void OnCompleted()
        {
            _rawProgress = LoopCount;
            RemainingDelay = 0f;
            
            base.OnCompleted();
        }
    }
}