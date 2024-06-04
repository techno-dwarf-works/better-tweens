using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class HorizontalFlipSpriteRendererTween : BoolTween<SpriteRenderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.flipX;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.flipX == value)
            {
                return;
            }

            Target.flipX = value;
        }
    }
}