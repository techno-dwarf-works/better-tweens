namespace Better.Tweens.Runtime.States
{
    public class RewindState : RunningState
    {
        public override void OnEntered()
        {
            base.OnEntered();

            if (IsActive)
            {
                Source.OnRewind();
            }
        }
    }
}