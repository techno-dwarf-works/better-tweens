namespace Better.Tweens.Runtime.States
{
    public abstract class RunningState : HandlingState
    {
        public override void OnEntered()
        {
            base.OnEntered();

            if (Token.IsCancellationRequested)
            {
                return;
            }

            Source.Enable();
            if (!Token.IsCancellationRequested)
            {
                Source.OnRunned();
            }
        }
    }
}