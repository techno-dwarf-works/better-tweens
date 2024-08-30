using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class GridSpacingLayoutGroupTween : Vector2Tween<GridLayoutGroup>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.spacing;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.spacing = value;
        }
    }
}