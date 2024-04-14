namespace Better.Tweens.Runtime.Triggers
{
    public class RewindingTweenCondition : TweenCoreCondition
    {
        private readonly bool _state;

        public RewindingTweenCondition(TweenCore source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return Source.IsRewinding() == _state;
        }
    }
}