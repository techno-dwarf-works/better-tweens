namespace Better.Tweens.Runtime.States
{
    public class StoppedState : HandlingState
    {
        private bool _suppressNotify;

        public void SuppressNextNotify()
        {
            _suppressNotify = true;
        }

        public override void OnEntered()
        {
            base.OnEntered();

            if (Token.IsCancellationRequested)
            {
                return;
            }

            Source.Sleep();
            if (!Token.IsCancellationRequested)
            {
                TryNotify();
            }
        }

        private void TryNotify()
        {
            if (_suppressNotify)
            {
                _suppressNotify = false;
                return;
            }

            Source.OnStopped();
        }
    }
}