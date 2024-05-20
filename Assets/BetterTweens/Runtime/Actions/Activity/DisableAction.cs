using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class DisableAction : SingleAction<DisableAction>
    {
        public DisableAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Disable();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsDisabled();
        }
    }
}