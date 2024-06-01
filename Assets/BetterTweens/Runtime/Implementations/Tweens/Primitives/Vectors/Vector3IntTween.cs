using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Vector3IntTween : Vector3Tween
    {
        protected sealed override void SetCurrentValue(Vector3 value)
        {
            var intValue = Vector3Int.RoundToInt(value);
            SetCurrentValue(intValue);
        }

        protected abstract void SetCurrentValue(Vector3Int value);
    }

    [Serializable]
    public abstract class Vector3IntTween<TTarget> : Vector3Tween<TTarget>
        where TTarget : class
    {
        protected sealed override void SetCurrentValue(Vector3 value)
        {
            var intValue = Vector3Int.RoundToInt(value);
            SetCurrentValue(intValue);
        }

        protected abstract void SetCurrentValue(Vector3Int value);
    }
}