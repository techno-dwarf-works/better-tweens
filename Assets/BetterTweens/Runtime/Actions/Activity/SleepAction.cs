using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class SleepAction : SingleAction<SleepAction>
    {
        public SleepAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Sleep();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsSleeping();
        }
    }
}