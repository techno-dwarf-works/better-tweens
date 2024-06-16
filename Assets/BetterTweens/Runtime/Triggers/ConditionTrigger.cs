#if BETTER_CONDITIONS
using Better.Conditions.Runtime;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime.Triggers
{
    public class ConditionTrigger : ActionTrigger
    {
        private readonly Condition _condition;

        public ConditionTrigger(string id, TweenCoreAction action, Condition condition) : base(id, action)
        {
            if (ValidationUtility.ValidateNullReference(condition))
            {
                _condition = condition;
            }
        }

        public override void Rebuild()
        {
            base.Rebuild();

            _condition.Rebuild();
        }

        public override bool Invoke(TweenCore tweenCore)
        {
            return _condition.Invoke() && base.Invoke(tweenCore);
        }
    }
}
#endif