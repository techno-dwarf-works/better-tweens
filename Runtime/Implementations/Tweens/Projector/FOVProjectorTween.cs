using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FOVProjectorTween : FloatTween<Projector>
    {
        protected override float GetCurrentValue()
        {
            return Target.fieldOfView;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.fieldOfView = value;
        }
    }
}