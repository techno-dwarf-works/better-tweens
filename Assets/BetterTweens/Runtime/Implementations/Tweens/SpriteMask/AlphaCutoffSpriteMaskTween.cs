using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AlphaCutoffSpriteMaskTween : FloatTween<SpriteMask>
    {
        protected override float GetCurrentValue()
        {
            return Target.alphaCutoff;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.alphaCutoff = value;
        }
    }
}