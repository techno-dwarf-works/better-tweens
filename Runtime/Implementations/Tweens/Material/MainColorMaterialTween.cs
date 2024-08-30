using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MainColorMaterialTween : ColorTween<Material>
    {
        protected override Color GetCurrentValue()
        {
            return Target.color;
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.color = value;
        }
    }
}