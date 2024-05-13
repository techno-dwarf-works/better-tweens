using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class ForceRewoundAction : SingleAction<ForceRewoundAction>
    {
        public ForceRewoundAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.ForceRewound();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsRewindable();
        }
    }
}