namespace Better.Tweens.Runtime.States
{
    public class PauseState : HandlingState
    {
        public override float ProgressMod => 0f;

        public override void Enter()
        {
            base.Enter();

            Source.Sleep();
            Source.OnPaused();
        }
    }
}