namespace Better.Tweens.Runtime.Triggers
{
    public class PausedTweenCondition : TweenCoreCondition
    {
        private readonly bool _state;

        public PausedTweenCondition(TweenCore source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return Source.IsPaused() == _state;
        }
    }
}