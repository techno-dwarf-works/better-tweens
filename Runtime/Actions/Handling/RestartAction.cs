using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class RestartAction : SingleAction<RestartAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Restart();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return true;
        }
    }
}