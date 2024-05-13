using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class TogglePauseAction : SingleAction<TogglePauseAction>
    {
        public TogglePauseAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.TogglePause();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsStopped();
        }
    }
}