using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class StopAction : SingleAction<StopAction>
    {
        public StopAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Stop();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsStopped();
        }
    }
}