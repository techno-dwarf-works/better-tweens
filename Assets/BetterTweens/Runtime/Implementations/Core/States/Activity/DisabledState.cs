namespace Better.Tweens.Runtime.States
{
    public class DisabledState : ActivityState
    {
        public override void Enter()
        {
            base.Enter();
            
            Source.OnDisabled();
        }
    }
}