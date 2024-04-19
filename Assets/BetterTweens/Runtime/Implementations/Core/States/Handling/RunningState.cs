namespace Better.Tweens.Runtime.States
{
    public abstract class RunningState : HandlingState
    {
        public override void Enter()
        {
            base.Enter();

            Source.Enable();
            Source.OnRunned();
        }

        public override void Tick(float deltaTime)
        {
            if (Source.InvokeTriggers())
            {
                return;
            }

            Source.ApplyProgressMod(ref deltaTime);
            Source.ApplyTimeScale(ref deltaTime);
            if (Source.DecreaseDelay(ref deltaTime) && Source.InDelay)
            {
                return;
            }

            Source.ApplyProgress(deltaTime);
        }
    }
}