using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class EnableAction : SingleAction<EnableAction>
    {
        public EnableAction()
        {
        }

        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Enable();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsEnabled();
        }
    }
}