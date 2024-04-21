namespace Better.Tweens.Runtime.States
{
    public class RewindState : RunningState
    {
        public override float ProgressMod => -1f;

        public override void Enter()
        {
            base.Enter();
            Source.OnRewind();
        }
    }
}