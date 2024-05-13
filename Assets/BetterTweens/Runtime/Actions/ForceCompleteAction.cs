using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class ForceCompleteAction : SingleAction<ForceCompleteAction>
    {
        public ForceCompleteAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.ForceComplete();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsCompletable();
        }
    }
}