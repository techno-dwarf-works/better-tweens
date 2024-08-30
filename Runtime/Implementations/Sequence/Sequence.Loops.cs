namespace Better.Tweens.Runtime
{
    public partial class Sequence
    {
        protected override void OnLoopCompleted()
        {
            _rootChannel.InstantComplete();
            
            base.OnLoopCompleted();
        }

        protected override void OnLoopRewound()
        {
            _rootChannel.InstantRewound();
            
            base.OnLoopRewound();
        }
    }
}