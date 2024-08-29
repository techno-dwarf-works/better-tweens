using System;
using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime.Sequences.Stages
{
    [Serializable]
    public abstract class SimpleStage : Stage
    {
        public sealed override async Task PlayAsync(CancellationToken cancellationToken)
        {
            await base.PlayAsync(cancellationToken);
            if (!cancellationToken.IsCancellationRequested)
            {
                Execute();
            }
        }

        public sealed override async Task RewindAsync(CancellationToken cancellationToken)
        {
            await base.RewindAsync(cancellationToken);
            if (!cancellationToken.IsCancellationRequested)
            {
                Execute();
            }
        }

        public sealed override void InstantComplete()
        {
            Execute();
        }

        public sealed override void InstantRewound()
        {
            Execute();
        }

        protected abstract void Execute();

        public override bool IsCompleted()
        {
            return true;
        }

        public override bool IsRewound()
        {
            return true;
        }
    }
}