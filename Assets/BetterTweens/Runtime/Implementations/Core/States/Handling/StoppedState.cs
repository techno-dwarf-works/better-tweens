namespace Better.Tweens.Runtime.States
{
    public class StoppedState : HandlingState
    {
        private bool _suppressNotify;

        public void SuppressNextNotify()
        {
            _suppressNotify = true;
        }

        public override void Enter()
        {
            base.Enter();

            Source.Sleep();
            TryNotify();
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