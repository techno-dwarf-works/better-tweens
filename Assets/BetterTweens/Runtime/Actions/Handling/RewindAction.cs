using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class RewindAction : SingleAction<RewindAction>
    {
        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Rewind();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsRewinding() && tweenCore.IsRewindable();
        }
    }
}