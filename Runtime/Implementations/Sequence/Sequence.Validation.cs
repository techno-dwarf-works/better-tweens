namespace Better.Tweens.Runtime
{
    public partial class Sequence
    {
        public override bool IsRunnable()
        {
            return base.IsRunnable() && !_rootChannel.IsEmpty;
        }

        public override bool IsCompleted()
        {
            return base.IsCompleted() && _rootChannel.IsCompleted();
        }

        public override bool IsRewound()
        {
            return base.IsRewound() && _rootChannel.IsRewound();
        }
    }
}