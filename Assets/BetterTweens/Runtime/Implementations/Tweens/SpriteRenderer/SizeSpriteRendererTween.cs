using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SizeSpriteRendererTween : Vector2Tween<SpriteRenderer>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.size;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.size = value;
        }
    }
}