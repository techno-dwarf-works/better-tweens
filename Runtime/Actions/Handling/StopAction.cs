using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class StopAction : SingleAction<StopAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Stop();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsStopped() && tweenCore.IsStoppable();
        }
    }
}