using System;
using UnityEngine;
using UnityEngine.U2D;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ColorSpriteShapeRendererTween : ColorTween<SpriteShapeRenderer>
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