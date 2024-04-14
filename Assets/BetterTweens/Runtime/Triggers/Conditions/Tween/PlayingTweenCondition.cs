namespace Better.Tweens.Runtime.Triggers
{
    public class PlayingTweenCondition : TweenCoreCondition
    {
        private readonly bool _state;

        public PlayingTweenCondition(TweenCore source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return Source.IsPlaying() == _state;
        }
    }
}