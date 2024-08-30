namespace Better.Tweens.Runtime.States
{
    public class DisabledState : ActivityState
    {
        public override void OnEntered()
        {
            base.OnEntered();

            Source.OnDisabled();
        }
    }
}