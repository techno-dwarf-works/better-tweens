using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Properties
{
    [Serializable]
    public class TweenProperties
    {
        private const float MinDuration = 10f; // TODO
        private const int MinLoopCount = 3; // TODO

        [Min(MinDuration)]
        [SerializeField] private float _duration;

        [Min(MinLoopCount)]
        [SerializeField] private int _loopCount;

        [SerializeField] private LoopMode _loopMode;
        [SerializeField] private OptionsMode _optionsMode;

        public float Duration => _duration;
        public int LoopCount => _loopCount;
        public LoopMode Mode => _loopMode;
        public OptionsMode OptionsMode => _optionsMode;

        public TweenProperties(float duration, int loopCount = MinLoopCount, LoopMode loopMode = default, OptionsMode optionsMode = default)
        {
            _duration = Mathf.Max(duration, MinDuration);
            _loopCount = Mathf.Max(loopCount, MinLoopCount);
            _loopMode = loopMode;
            _optionsMode = optionsMode;
        }

        public TweenProperties() : this(MinDuration)
        {
            //
        }

        public virtual void Copy(TweenProperties other)
        {
            // TODO
        }
    }
}