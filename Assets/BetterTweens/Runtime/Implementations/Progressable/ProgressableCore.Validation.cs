namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        public override bool IsRewound()
        {
            return base.IsRewound() && LoopProgress <= 0f;
        }
    }
}