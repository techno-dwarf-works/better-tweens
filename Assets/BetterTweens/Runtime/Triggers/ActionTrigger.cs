using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class ActionTrigger : Trigger
    {
        private readonly TweenCoreAction _action;

        public ActionTrigger(string id, TweenCoreAction action) : base(id)
        {
            if (ValidationUtility.ValidateNullReference(action))
            {
                _action = action;
            }
        }

        public override bool Invoke(TweenCore tweenCore)
        {
            return _action.TryInvoke(tweenCore);
        }
    }
}