namespace Better.Tweens.Runtime.States
{
    public class PauseState : HandlingState
    {
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
                Source.OnPaused();
            }
        }
    }
}