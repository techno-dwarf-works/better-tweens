using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Vector2IntTween : Vector2Tween
    {
        protected sealed override void SetCurrentValue(Vector2 value)
        {
            var intValue = Vector2Int.RoundToInt(value);
            SetCurrentValue(intValue);
        }

        protected abstract void SetCurrentValue(Vector2Int value);
    }

    [Serializable]
    public abstract class Vector2IntTween<TTarget> : Vector2Tween<TTarget>
        where TTarget : class
    {
        protected sealed override void SetCurrentValue(Vector2 value)
        {
            var intValue = Vector2Int.RoundToInt(value);
            SetCurrentValue(intValue);
        }

        protected abstract void SetCurrentValue(Vector2Int value);
    }
}