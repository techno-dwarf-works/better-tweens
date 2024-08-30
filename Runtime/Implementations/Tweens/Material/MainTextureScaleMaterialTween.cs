using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MainTextureScaleMaterialTween : Vector2Tween<Material>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.mainTextureScale;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.mainTextureScale = value;
        }
    }
}