using System.Collections.Generic;
using Better.Commons.Runtime.Extensions;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class Trigger
    {
        public const string UndefinedTag = nameof(UndefinedTag);
        private HashSet<TriggerCondition> _conditions;
        private string _tag;

        internal void Initialize(string tag, HashSet<TriggerCondition> conditions)
        {
            _tag = tag;
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

        public bool CompareTag(string tag)
        {
            return _tag == tag;
        }
    }
}