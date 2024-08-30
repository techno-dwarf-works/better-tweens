using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class SleepAction : SingleAction<SleepAction>
    {
        public SleepAction()
        {
        }

        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Sleep();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsSleeping();
        }
    }
}