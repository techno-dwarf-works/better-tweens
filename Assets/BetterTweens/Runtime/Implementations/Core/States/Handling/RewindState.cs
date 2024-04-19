namespace Better.Tweens.Runtime.States
{
    public class RewindState : RunningState
    {
        public override void Enter()
        {
            base.Enter();
            Source.OnRewind();
        }

        public override void Tick(float deltaTime)
        {
            var inversedDeltaTime = -deltaTime;
            base.Tick(inversedDeltaTime);
        }
    }
}