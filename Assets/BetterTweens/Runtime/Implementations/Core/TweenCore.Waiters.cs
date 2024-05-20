using System.Collections;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        // TODO: Update waiters
        public IEnumerator WaitForUpdate() => new WaitForTweenUpdated(this);
        public IEnumerator WaitForStopped() => new WaitForTweenStopped(this);
        public IEnumerator WaitForStateChange() => new WaitForTweenStateChange(this);
        public IEnumerator WaitForRewound() => new WaitForTweenRewound(this);
        public IEnumerator WaitForRewindStarted() => new WaitForTweenRewindStarted(this);
        public IEnumerator WaitForRewinding() => new WaitForTweenRewinding(this);
        public IEnumerator WaitForPlayStarted() => new WaitForTweenPlayStarted(this);
        public IEnumerator WaitForPlaying() => new WaitForTweenPlaying(this);
        public IEnumerator WaitForPaused() => new WaitForTweenPaused(this);
        public IEnumerator WaitForCompletion() => new WaitForTweenCompletion(this);
        public IEnumerator WaitForActivated() => new WaitForTweenRunned(this);
        public IEnumerator WaitForLoopCompleted(int count = WaitForTweenLoop.MinCount) => new WaitForTweenLoopCompleted(this, count);
        public IEnumerator WaitForLoopRewound(int count = WaitForTweenLoop.MinCount) => new WaitForTweenLoopRewound(this, count);
    }
}