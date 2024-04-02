using System;
using Better.Tweens.Runtime.Logs;
using UnityEngine;

namespace Better.Tweens.Runtime.Properties
{
    [Serializable]
    public abstract class CoreProperties
    {
        private const float MinDuration = 0f;
        private const float MinDelay = 0f;
        private const int MinLoopCount = 1;

        [Min(MinDuration)]
        [SerializeField] private float _duration;

        [Min(MinDelay)]
        [SerializeField] private float _startDelay;

        [Min(MinDelay)]
        [SerializeField] private float _loopDelay;

        [Min(MinLoopCount)]
        [SerializeField] private int _loopCount;

        [SerializeField] private LoopMode _loopMode;
        [SerializeField] private OptionsMode _optionsMode;

        public float Duration
        {
            get => _duration;
            internal set
            {
                if (value < MinDuration)
                {
                    var message = $"{nameof(Duration)} cannot be less of {nameof(MinDuration)}({MinDuration}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDuration;
                }

                _duration = value;
            }
        }

        public float StartDelay
        {
            get => _startDelay;
            internal set
            {
                if (value < MinDelay)
                {
                    var message = $"{nameof(StartDelay)} cannot be less of {nameof(MinDelay)}({MinDelay}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDelay;
                }

                _startDelay = value;
            }
        }

        public float LoopDelay
        {
            get => _loopDelay;
            internal set
            {
                if (value < MinDelay)
                {
                    var message = $"{nameof(LoopDelay)} cannot be less of {nameof(MinDelay)}({MinDelay}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDelay;
                }

                _loopDelay = value;
            }
        }

        public int LoopCount
        {
            get => _loopCount;
            internal set
            {
                if (value < MinLoopCount)
                {
                    var message = $"{nameof(LoopCount)} cannot be less of {nameof(MinLoopCount)}({MinLoopCount}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinLoopCount;
                }

                _loopCount = value;
            }
        }

        public LoopMode LoopMode
        {
            get => _loopMode;
            internal set => _loopMode = value;
        }

        public CoreProperties()
        {
            _loopCount = MinLoopCount;
        }
    }
}