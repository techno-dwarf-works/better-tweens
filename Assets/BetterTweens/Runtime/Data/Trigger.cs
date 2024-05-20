using System;
using Better.Commons.Runtime.Extensions;
using Better.Conditions.Runtime;
using Better.Tweens.Runtime.Actions;

namespace Better.Tweens.Runtime.Triggers
{
    public class Trigger
    {
        public const string UndefinedId = nameof(UndefinedId);

        private readonly string _id;
        private readonly TweenCoreAction _action;
        private readonly Condition _condition;

        public Trigger(string id, TweenCoreAction action, Condition condition)
        {
            if (id.IsNullOrEmpty())
            {
                var message = $"{nameof(id)} cannot be null or empty";
                throw new ArgumentException(message);
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }

            _id = id;
            _action = action;
            _condition = condition;
        }

        public void Rebuild()
        {
            _condition.Rebuild();
        }

        public bool Invoke(TweenCore tweenCore)
        {
            if (_action.ReadinessFor(tweenCore)
                && _condition.Invoke())
            {
                _action.Invoke(tweenCore);
                return true;
            }

            return false;
        }

        public bool CompareId(string value)
        {
            return _id == value;
        }
    }
}