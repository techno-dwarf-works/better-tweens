using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MainTextureOffsetMaterialTween : Vector2Tween<Material>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.mainTextureOffset;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.mainTextureOffset = value;
        }
    }
}