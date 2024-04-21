using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StopCompletionBehaviour : CompletionBehaviour
    {
        public StopCompletionBehaviour()
        {
        }

        protected internal override void Invoke(TweenCore source)
        {
            source.Stop();
        }

        public override CompletionBehaviour Clone()
        {
            return new StopCompletionBehaviour();
        }
    }
}