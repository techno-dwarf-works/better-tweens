namespace Better.Tweens.Runtime.Triggers
{
    public class NullReferenceTrigger : Trigger<object>
    {
        public NullReferenceTrigger(TweenCore tweenCore, TriggerActionType actionType, object source)
            : base(tweenCore, actionType, source)
        {
        }

        protected override bool ConditionMet()
        {
            return Source == null;
        }
    }
}