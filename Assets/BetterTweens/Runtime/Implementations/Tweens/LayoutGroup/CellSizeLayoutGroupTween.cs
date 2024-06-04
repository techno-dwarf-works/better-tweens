using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CellSizeLayoutGroupTween : Vector2Tween<GridLayoutGroup>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.cellSize;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.cellSize = value;
        }
    }
}