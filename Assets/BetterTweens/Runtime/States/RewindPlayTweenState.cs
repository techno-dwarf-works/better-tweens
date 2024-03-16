using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class RewindPlayTweenState : PlayingTweenState
    {
        public RewindPlayTweenState(Tween source) : base(source)
        {
        }

        protected override float ProgressMod => 1f / Source.Duration * -1f;

        public override void ApplyProgress(float value)
        {
            base.ApplyProgress(value);

            if (Mathf.Approximately(Source.Progress, default))
            {
                Source.Pause();
            }
        }
    }
}