using System;
using Better.Tweens.Runtime.Actions;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class ActionTrigger : Trigger
    {
        private readonly TweenCoreAction _action;

        public ActionTrigger(string id, TweenCoreAction action) : base(id)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            _action = action;
        }

        public override bool Invoke(TweenCore tweenCore)
        {
            return _action.TryInvoke(tweenCore);
        }
    }
}