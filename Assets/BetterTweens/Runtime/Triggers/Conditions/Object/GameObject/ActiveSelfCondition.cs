using UnityEngine;

namespace Better.Tweens.Runtime.Triggers
{
    public class ActiveSelfCondition : ObjectCondition<GameObject>
    {
        private readonly bool _state;

        public ActiveSelfCondition(GameObject source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return !IsNullSource() && Source.activeSelf == _state;
        }
    }
}