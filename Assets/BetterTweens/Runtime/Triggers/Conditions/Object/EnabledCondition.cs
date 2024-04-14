using UnityEngine;

namespace Better.Tweens.Runtime.Triggers
{
    public class EnabledCondition : ObjectCondition<MonoBehaviour>
    {
        private readonly bool _state;

        public EnabledCondition(MonoBehaviour source, bool state = true) : base(source)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return !IsNullSource() && Source.enabled == _state;
        }
    }
}