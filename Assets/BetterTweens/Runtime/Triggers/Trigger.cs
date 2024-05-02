using System.Collections.Generic;
using Better.Commons.Runtime.Extensions;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class Trigger
    {
        public const string UndefinedId = nameof(UndefinedId);
        private HashSet<TriggerCondition> _conditions;
        private string _id;

        internal void Initialize(string id, HashSet<TriggerCondition> conditions)
        {
            _id = id;
            _conditions = conditions;
        }

        internal bool TryInvoke(TweenCore source)
        {
            if (IsValidFor(source) && ConditionsMet())
            {
                Invoke(source);
                return true;
            }

            return false;
        }

        private bool ConditionsMet()
        {
            if (_conditions.IsEmpty())
            {
                return false;
            }

            foreach (var condition in _conditions)
            {
                if (!condition.Validate())
                {
                    return false;
                }
            }

            return true;
        }

        protected abstract void Invoke(TweenCore tweenCore);

        protected abstract bool IsValidFor(TweenCore tweenCore);

        public bool CompareId(string value)
        {
            return _id == value;
        }
    }
}