using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ConstraintCountLayoutGroupTween : IntTween<GridLayoutGroup>
    {
        protected override int GetCurrentValue()
        {
            return Target.constraintCount;
        }

        protected override void SetCurrentValue(int value)
        {
            if (Target.constraintCount == value)
            {
                return;
            }

            Target.constraintCount = value;
        }
    }
}