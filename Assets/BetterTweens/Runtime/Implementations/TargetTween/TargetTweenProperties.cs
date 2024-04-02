using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Properties
{
    [Serializable]
    public class TargetTweenProperties<TTarget, TValue> : TweenProperties<TValue>
    {
        [SerializeField] private TTarget _target;

        public TTarget Target
        {
            get => _target;
            internal set => _target = value;
        }
    }
}