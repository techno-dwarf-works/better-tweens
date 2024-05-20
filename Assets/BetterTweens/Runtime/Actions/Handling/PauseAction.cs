using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class PauseAction : SingleAction<PauseAction>
    {
        public PauseAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Pause();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return tweenCore.IsPausable();
        }
    }
}