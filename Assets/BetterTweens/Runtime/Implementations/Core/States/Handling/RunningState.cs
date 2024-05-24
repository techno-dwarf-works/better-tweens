namespace Better.Tweens.Runtime.States
{
    public abstract class RunningState : HandlingState
    {
        public override void OnEntered()
        {
            base.OnEntered();

            if (!IsActive)
            {
                return;
            }

            Source.Enable();
            if (IsActive)
            {
                Source.OnRunned();
            }
        }
    }
}