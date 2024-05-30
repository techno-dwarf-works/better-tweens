using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class DisableAction : SingleAction<DisableAction>
    {
        public DisableAction()
        {
        }

        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Disable();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsDisabled();
        }
    }
}