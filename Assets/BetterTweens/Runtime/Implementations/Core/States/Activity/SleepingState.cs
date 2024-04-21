namespace Better.Tweens.Runtime.States
{
    public class SleepingState : ActivityState
    {
        private float _elapsedTime;

        public override void Enter()
        {
            base.Enter();

            TweenRegistry.Register(Source);
            Source.OnAsleep();
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);

            _elapsedTime += deltaTime;
            if (!Source.InfinitySleeping && _elapsedTime >= Source.SleepingDuration)
            {
                Source.Disable();
            }
        }

        public override void Reset()
        {
            base.Reset();

            _elapsedTime = default;
        }

        public override void Exit()
        {
            base.Exit();

            TweenRegistry.Unregister(Source);
        }
    }
}