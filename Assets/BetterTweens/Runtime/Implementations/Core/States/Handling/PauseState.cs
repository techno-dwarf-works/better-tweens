namespace Better.Tweens.Runtime.States
{
    public class PauseState : HandlingState
    {
        public override void OnEntered()
        {
            base.OnEntered();

            if (!IsActive)
            {
                return;
            }

            Source.Sleep();
            if (IsActive)
            {
                Source.OnPaused();
            }
        }
    }
}