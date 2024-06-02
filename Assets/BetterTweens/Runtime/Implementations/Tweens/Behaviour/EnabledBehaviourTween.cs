using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class EnabledBehaviourTween : BoolTween<Behaviour>
    {
        protected override bool GetCurrentValue()
        {
            return Target.enabled;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.enabled = value;
        }
    }
}