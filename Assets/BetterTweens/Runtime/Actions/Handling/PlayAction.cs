using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class PlayAction : SingleAction<PlayAction>
    {
        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Play();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsPlaying() && tweenCore.IsPlayable();
        }
    }
}