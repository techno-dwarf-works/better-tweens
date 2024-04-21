using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RewindCompletionBehaviour : CompletionBehaviour
    {
        public RewindCompletionBehaviour()
        {
        }

        protected internal override void Invoke(TweenCore source)
        {
            source.Rewind();
        }

        public override CompletionBehaviour Clone()
        {
            return new RewindCompletionBehaviour();
        }
    }
}