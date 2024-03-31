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
    }
}