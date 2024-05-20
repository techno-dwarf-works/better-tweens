﻿using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        // TODO: Update awaiters
        private Task AwaitUpdate(CancellationToken cancellationToken = default) => new TweenUpdateAwaiter(this, cancellationToken).Task;
        private Task AwaitStopped(CancellationToken cancellationToken = default) => new TweenStoppedAwaiter(this, cancellationToken).Task;
        private Task AwaitStateChange(CancellationToken cancellationToken = default) => new TweenStateChangeAwaiter(this, cancellationToken).Task;
        private Task AwaitRewound(CancellationToken cancellationToken = default) => new TweenRewoundAwaiter(this, cancellationToken).Task;
        private Task AwaitRewindStarted(CancellationToken cancellationToken = default) => new TweenRewindStartedAwaiter(this, cancellationToken).Task;
        private Task AwaitRewinding(CancellationToken cancellationToken = default) => new TweenRewindingAwaiter(this, cancellationToken).Task;
        private Task AwaitPlayStarted(CancellationToken cancellationToken = default) => new TweenPlayStartedAwaiter(this, cancellationToken).Task;
        private Task AwaitPlaying(CancellationToken cancellationToken = default) => new TweenPlayingAwaiter(this, cancellationToken).Task;
        private Task AwaitPaused(CancellationToken cancellationToken = default) => new TweenPausedAwaiter(this, cancellationToken).Task;
        private Task AwaitCompletion(CancellationToken cancellationToken = default) => new TweenCompletionAwaiter(this, cancellationToken).Task;
        private Task AwaitActivated(CancellationToken cancellationToken = default) => new TweenRunAwaiter(this, cancellationToken).Task;

        private Task AwaitLoopCompleted(int count = WaitForTweenLoop.MinCount, CancellationToken cancellationToken = default)
        {
            return new TweenLoopCompletedAwaiter(this, cancellationToken, count).Task;
        }

        private Task AwaitLoopRewound(int count = WaitForTweenLoop.MinCount, CancellationToken cancellationToken = default)
        {
            return new TweenLoopRewoundAwaiter(this, cancellationToken, count).Task;
        }
    }
}