using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class InstantCompleteAction : SingleAction<InstantCompleteAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.InstantComplete();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return tweenCore.IsCompletable();
        }
    }
}