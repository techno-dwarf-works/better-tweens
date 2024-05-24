namespace Better.Tweens.Runtime.States
{
    public class PlayingState : RunningState
    {
        private bool _startTrigger;

        public override void OnEntered()
        {
            OnPreEntered();
            base.OnEntered();

            if (IsActive)
            {
                Source.OnPlay();
            }
        }

        private void OnPreEntered()
        {
            if (!IsActive)
            {
                return;
            }

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