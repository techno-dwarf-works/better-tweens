using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class RestartAction : SingleAction<RestartAction>
    {
        public RestartAction()
        {
        }

        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Restart();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return true;
        }
    }
}