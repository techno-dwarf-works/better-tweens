using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class InstantRewoundAction : SingleAction<InstantRewoundAction>
    {
        public InstantRewoundAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.InstantRewound();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return tweenCore.IsRewindable();
        }
    }
}