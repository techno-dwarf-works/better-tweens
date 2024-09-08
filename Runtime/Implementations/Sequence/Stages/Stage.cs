using System;
using System.Threading;
using System.Threading.Tasks;
using Better.Commons.Runtime.Interfaces;

namespace Better.Tweens.Runtime.Sequences.Stages
{
    [Serializable]
    public abstract class Stage : ICloneable<Stage>
    {
        public virtual void Start()
        {
        }

        public virtual Task PlayAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public virtual Task RewindAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public virtual void InstantComplete()
        {
        }

        public virtual void InstantRewound()
        {
        }

        public virtual void Pause()
        {
        }

        public virtual void Stop()
        {
        }

        public abstract bool IsCompleted();
        public abstract bool IsRewound();
        public abstract Stage Clone();
    }
}