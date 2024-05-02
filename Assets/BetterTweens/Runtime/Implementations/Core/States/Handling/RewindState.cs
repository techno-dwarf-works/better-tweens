namespace Better.Tweens.Runtime.States
{
    public class RewindState : RunningState
    {
        public override void Enter()
        {
            base.Enter();
            Source.OnRewind();
        }
    }
}