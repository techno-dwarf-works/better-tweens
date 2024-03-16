using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract class PlayingTweenState : TweenState
    {
        protected abstract float ProgressMod { get; }

        public PlayingTweenState(Tween source) : base(source)
        {
        }

        public override void ApplyProgress(float value)
        {
            var progress = Source.Progress;
            progress += value * ProgressMod;
            progress = Mathf.Clamp(progress, default, Tween.MaxProgress);
            Source.Progress = progress;
            Source.ApplyState_Tween();
        }
    }
}