using System;
using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime.Sequences.Channels
{
    [Serializable]
    public abstract class Channel
    {
        public abstract void PrependCallback(Action callback);
        public abstract void AppendCallback(Action callback);
        public abstract void PrependInterval(float duration);
        public abstract void AppendInterval(float duration);
        public abstract void AppendTween(Tween tween);
        public abstract void PrependTween(Tween tween);
        public abstract void JoinTween(Tween tween);
        public abstract void AppendLog(string message);

        public abstract void Start();
        public abstract Task PlayAsync(CancellationToken cancellationToken);
        public abstract Task RewindAsync(CancellationToken cancellationToken);
        public abstract void InstantComplete();
        public abstract void InstantRewound();
        public abstract void Pause();
        public abstract void Stop();
        public abstract void PrependLog(string message);
        public abstract bool IsRewound();
        public abstract bool IsCompleted();
    }
}