using System.Collections;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        private IEnumerator WaitUpdate() => new WaitTweenUpdated(this);
        private IEnumerator WaitStopped() => new WaitTweenStopped(this);
        private IEnumerator WaitStateChange() => new WaitTweenStateChange(this);
        private IEnumerator WaitRewound() => new WaitTweenRewound(this);
        private IEnumerator WaitRewindStarted() => new WaitTweenRewindStarted(this);
        private IEnumerator WaitRewinding() => new WaitTweenRewinding(this);
        private IEnumerator WaitPlayStarted() => new WaitTweenPlayStarted(this);
        private IEnumerator WaitPlaying() => new WaitTweenPlaying(this);
        private IEnumerator WaitPaused() => new WaitTweenPaused(this);
        private IEnumerator WaitCompleted() => new WaitTweenCompleted(this);
        private IEnumerator WaitActivated() => new WaitTweenActivated(this);
        private IEnumerator WaitLoopCompleted(int count = WaitTweenLoop.MinCount) => new WaitTweenLoopCompleted(this, count);
        private IEnumerator WaitLoopRewound(int count = WaitTweenLoop.MinCount) => new WaitTweenLoopRewound(this, count);
    }
}