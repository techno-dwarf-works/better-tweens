using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class InstantCompleteAction : SingleAction<InstantCompleteAction>
    {
        public InstantCompleteAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.InstantComplete();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return tweenCore.IsCompletable();
        }
    }
}