using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RestartCompletionBehaviour : CompletionBehaviour
    {
        public RestartCompletionBehaviour()
        {
        }

        protected internal override void Invoke(TweenCore source)
        {
            source.Restart();
        }

        public override CompletionBehaviour Clone()
        {
            return new RestartCompletionBehaviour();
        }
    }
}