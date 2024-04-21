using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class CompletionBehaviour
    {
        protected internal abstract void Invoke(TweenCore source);
        public abstract CompletionBehaviour Clone();
    }
}