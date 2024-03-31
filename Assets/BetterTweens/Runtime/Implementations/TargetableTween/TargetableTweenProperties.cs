using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Properties
{
    [Serializable]
    public class TargetableTweenProperties<TTarget> : TweenProperties
    {
        [SerializeField] private TTarget _target;

        public TTarget Target
        {
            get => _target;
            internal set => _target = value;
        }
    }
}