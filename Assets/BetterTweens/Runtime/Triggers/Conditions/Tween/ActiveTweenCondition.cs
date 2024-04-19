namespace Better.Tweens.Runtime.Triggers
{
    public class ActiveTweenCondition : TweenCoreCondition
    {
        private readonly bool _state;

        public ActiveTweenCondition(TweenCore source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return Source.IsRunning() == _state;
        }
    }
}