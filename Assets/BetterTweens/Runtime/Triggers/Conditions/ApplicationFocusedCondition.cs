using UnityEngine;

namespace Better.Tweens.Runtime.Triggers
{
    public class ApplicationFocusedCondition : TriggerCondition
    {
        private readonly bool _state;

        public ApplicationFocusedCondition(bool state)
        {
            _state = state;
        }

        public override bool Validate()
        {
            return Application.isFocused == _state;
        }
    }
}