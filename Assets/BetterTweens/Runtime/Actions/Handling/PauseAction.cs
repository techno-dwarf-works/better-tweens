using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class PauseAction : SingleAction<PauseAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Pause();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsPaused() && tweenCore.IsPausable();
        }
    }
}