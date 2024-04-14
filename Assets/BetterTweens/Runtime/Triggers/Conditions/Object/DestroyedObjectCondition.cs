using UnityEngine;

namespace Better.Tweens.Runtime.Triggers
{
    public class DestroyObjectCondition : ObjectCondition<Object>
    {
        private readonly bool _destroyed;

        public DestroyObjectCondition(Object source, bool destroyed = true) : base(source)
        {
            _destroyed = destroyed;
        }

        public override bool Validate()
        {
            return IsNullSource() == _destroyed;
        }
    }
}