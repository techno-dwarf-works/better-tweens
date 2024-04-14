namespace Better.Tweens.Runtime.Triggers
{
    public class MutableTweenCondition : TweenCoreCondition
    {
        private readonly bool _state;

        public MutableTweenCondition(TweenCore source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return Source.IsMutable() == _state;
        }
    }
}