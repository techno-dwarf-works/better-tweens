using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class EnableAction : SingleAction<EnableAction>
    {
        public EnableAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Enable();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsEnabled();
        }
    }
}