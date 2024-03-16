using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class LinearPlayTweenState : PlayingTweenState
    {
        public LinearPlayTweenState(Tween source) : base(source)
        {
        }

        protected override float ProgressMod => 1f / Source.Duration;

        public override void ApplyProgress(float value)
        {
            base.ApplyProgress(value);

            if (Mathf.Approximately(Source.Progress, Tween.MaxProgress))
            {
                Source.Kill(true);
            }
        }
    }
}