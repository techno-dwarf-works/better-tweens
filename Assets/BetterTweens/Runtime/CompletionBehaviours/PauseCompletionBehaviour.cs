using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PauseCompletionBehaviour : CompletionBehaviour
    {
        public PauseCompletionBehaviour()
        {
        }

        protected internal override void Invoke(TweenCore source)
        {
            source.Pause();
        }

        public override CompletionBehaviour Clone()
        {
            return new PauseCompletionBehaviour();
        }
    }
}