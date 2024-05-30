using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class RewindAction : SingleAction<RewindAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Rewind();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsRewinding() && tweenCore.IsRewindable();
        }
    }
}