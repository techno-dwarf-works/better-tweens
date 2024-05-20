using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public abstract class TweenCoreAction
    {
        public bool TryInvoke(TweenCore tweenCore)
        {
            if (ReadinessFor(tweenCore))
            {
                Invoke(tweenCore);
                return true;
            }

            return false;
        }

        public abstract void Invoke(TweenCore tweenCore);
        public abstract bool ReadinessFor(TweenCore tweenCore);
        public abstract TweenCoreAction Clone();
    }
}