namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        public override bool IsRewound()
        {
            // TODO: Fix Play 1 loop, rewind... rewound when backward to 0 loop, not 0_progress 0_loop
            
            return base.IsRewound() && LoopProgress <= 0f;
        }
    }
}