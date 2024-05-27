namespace Better.Tweens.Runtime.States
{
    public class PlayingState : RunningState
    {
        private bool _startTrigger;

        public override void OnEntered()
        {
            base.OnEntered();
            TryStartNotify();
            
            if (Token.IsCancellationRequested)
            {
                return;
            }

            Source.OnPlay();
        }

        private void TryStartNotify()
        {
            if (Token.IsCancellationRequested) return;

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