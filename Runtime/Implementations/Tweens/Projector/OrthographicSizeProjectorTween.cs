using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class OrthographicSizeProjectorTween : FloatTween<Projector>
    {
        protected override float GetCurrentValue()
        {
            return Target.orthographicSize;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.orthographicSize = value;
        }
    }
}