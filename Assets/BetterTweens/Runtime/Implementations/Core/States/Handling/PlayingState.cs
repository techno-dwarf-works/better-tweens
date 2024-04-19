namespace Better.Tweens.Runtime.States
{
    public class PlayingState : RunningState
    {
        private bool _startTrigger;

        public override void Enter()
        {
            OnPreEnter();
            base.Enter();

            Source.OnPlay();
        }

        private void OnPreEnter()
        {
            if (_startTrigger)
            {
                _startTrigger = false;
                Source.OnStarted();
            }
        }

        public void MarkStartTrigger()
        {
            _startTrigger = true;
        }
    }
}