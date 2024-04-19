namespace Better.Tweens.Runtime.States
{
    public class SleepingState : ActivityState
    {
        public override void Enter()
        {
            base.Enter();
            Source.OnAsleep();
        }
    }
}