using System;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public TweenCore SetDuration(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinDuration)
                {
                    var message = $"{nameof(Duration)} cannot be less of {nameof(MinDuration)}({MinDuration}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDuration;
                }

                _duration = value;
            }

            return this;
        }

        public TweenCore SetStartDelay(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinDelay)
                {
                    var message = $"{nameof(StartDelay)} cannot be less of {nameof(MinDelay)}({MinDelay}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDelay;
                }

                _startDelay = value;
            }

            return this;
        }

        public TweenCore SetLoopDelay(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinDelay)
                {
                    var message = $"{nameof(LoopDelay)} cannot be less of {nameof(MinDelay)}({MinDelay}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDelay;
                }

                _loopDelay = value;
            }

            return this;
        }

        public TweenCore SetLoopCount(int value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinLoopCount)
                {
                    var message = $"{nameof(LoopCount)} cannot be less of {nameof(MinLoopCount)}({MinLoopCount}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinLoopCount;
                }

                _loopCount = value;
            }

            return this;
        }

        public TweenCore SetLoopMode(LoopMode value)
        {
            if (ValidateMutable(true))
            {
                _loopMode = value;
            }

            return this;
        }

        public TweenCore SetLoops(int count, LoopMode loopMode)
        {
            SetLoopCount(count);
            SetLoopMode(loopMode);

            return this;
        }

        public TweenCore DependencyUnityTimeScale(bool depend)
        {
            if (ValidateMutable(true))
            {
                _dependUnityTimeScale.Override(depend);
            }

            return this;
        }

        public TweenCore DependencyGlobalTimeScale(bool value)
        {
            if (ValidateMutable(true))
            {
                _dependGlobalTimeScale.Override(value);
            }

            return this;
        }

        public TweenCore SetLocalTimeScale(float value)
        {
            if (ValidateMutable(true))
            {
                _localTimeScale = value;
            }

            return this;
        }

        #region Events

        public TweenCore OnStarted(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Started += callback;
            }

            return this;
        }

        public TweenCore OnActivated(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Activated += callback;
            }

            return this;
        }

        public TweenCore OnPlaying(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Playing += callback;
            }

            return this;
        }

        public TweenCore OnRewinding(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Rewinding += callback;
            }

            return this;
        }

        public TweenCore OnUpdated(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Updated += callback;
            }

            return this;
        }

        public TweenCore OnPaused(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Paused += callback;
            }

            return this;
        }

        public TweenCore OnStopped(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Stopped += callback;
            }

            return this;
        }

        public TweenCore OnCompleted(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Completed += callback;
            }

            return this;
        }

        public TweenCore OnRewound(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Rewound += callback;
            }

            return this;
        }

        public TweenCore OnLoopCompleted(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                LoopCompleted += callback;
            }

            return this;
        }

        public TweenCore OnLoopRewound(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                LoopRewound += callback;
            }

            return this;
        }

        #endregion
    }
}