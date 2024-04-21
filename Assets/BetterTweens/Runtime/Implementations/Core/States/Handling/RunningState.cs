namespace Better.Tweens.Runtime.States
{
    public abstract class RunningState : HandlingState
    {
        public override float ProgressMod => 1f;

        public override void Enter()
        {
            base.Enter();

            Source.Enable();
            Source.OnRunned();
        }
    }
}