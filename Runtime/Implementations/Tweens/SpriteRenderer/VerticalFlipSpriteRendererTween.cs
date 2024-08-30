using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class VerticalFlipSpriteRendererTween : BoolTween<SpriteRenderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.flipY;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.flipY == value)
            {
                return;
            }

            Target.flipY = value;
        }
    }
}