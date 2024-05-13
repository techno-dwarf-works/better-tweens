using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public abstract class TweenCoreAction
    {
        public abstract void Invoke(TweenCore tweenCore);
        public abstract bool ReadinessFor(TweenCore tweenCore);
        public abstract TweenCoreAction Clone();
    }
}