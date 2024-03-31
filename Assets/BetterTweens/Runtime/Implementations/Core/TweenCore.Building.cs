using System;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public TweenCore SetDuration(float value)
        {
            if (ValidateMutable(true))
            {
                DerivedProperties.Duration = value;
            }

            return this;
        }

        public TweenCore SetStartDelay(float value)
        {
            if (ValidateMutable(true))
            {
                DerivedProperties.StartDelay = value;
            }

            return this;
        }

        public TweenCore SetLoopDelay(float value)
        {
            if (ValidateMutable(true))
            {
                DerivedProperties.LoopDelay = value;
            }

            return this;
        }

        public TweenCore SetLoopCount(int value)
        {
            if (ValidateMutable(true))
            {
                DerivedProperties.LoopCount = value;
            }

            return this;
        }

        public TweenCore SetLoopMode(LoopMode value)
        {
            if (ValidateMutable(true))
            {
                DerivedProperties.LoopMode = value;
            }

            return this;
        }

        public TweenCore SetLoops(int count, LoopMode loopMode)
        {
            SetLoopCount(count);
            SetLoopMode(loopMode);

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