using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class TogglePauseAction : SingleAction<TogglePauseAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.TogglePause();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return tweenCore.IsPausable() || tweenCore.IsPlayable();
        }
    }
}