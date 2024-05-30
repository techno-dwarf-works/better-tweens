using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class InstantRewoundAction : SingleAction<InstantRewoundAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.InstantRewound();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return tweenCore.IsRewindable();
        }
    }
}