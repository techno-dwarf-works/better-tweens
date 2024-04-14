using UnityEngine;

namespace Better.Tweens.Runtime.Triggers
{
    public class ActiveInHierarchyCondition : ObjectCondition<GameObject>
    {
        private readonly bool _state;

        public ActiveInHierarchyCondition(GameObject source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return !IsNullSource() && Source.activeInHierarchy == _state;
        }
    }
}