using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class PlayAction : SingleAction<PlayAction>
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Play();
        }

        protected override bool ReadinessFor(TweenCore tweenCore)
        {
            return !tweenCore.IsPlaying() && tweenCore.IsPlayable();
        }
    }
}