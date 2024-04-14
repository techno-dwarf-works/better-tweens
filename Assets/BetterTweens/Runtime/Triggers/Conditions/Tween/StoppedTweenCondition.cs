namespace Better.Tweens.Runtime.Triggers
{
    public class StoppedTweenCondition : TweenCoreCondition
    {
        private readonly bool _state;

        public StoppedTweenCondition(TweenCore source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return Source.IsStopped() == _state;
        }
    }
}