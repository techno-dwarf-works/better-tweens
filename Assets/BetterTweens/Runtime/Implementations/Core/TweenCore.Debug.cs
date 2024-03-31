using System;
using System.Text;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public override string ToString()
        {
            const string separator = ": ";

            return new StringBuilder()
                .AppendJoin(separator, nameof(Type), GetType())
                .AppendJoin(separator, nameof(Initialized), Initialized)
                .AppendJoin(separator, nameof(Duration), Duration)
                .AppendJoin(separator, nameof(StartDelay), StartDelay)
                .AppendJoin(separator, nameof(LoopDelay), LoopDelay)
                .AppendJoin(separator, nameof(RemainingDelay), RemainingDelay)
                .AppendJoin(separator, nameof(InDelay), InDelay)
                .AppendJoin(separator, nameof(LoopProgress), LoopProgress)
                .AppendJoin(separator, nameof(TotalProgress), TotalProgress)
                .AppendJoin(separator, nameof(LoopCount), LoopCount)
                .AppendJoin(separator, nameof(LoopMode), LoopMode)
                .AppendJoin(separator, nameof(CompletedLoops), CompletedLoops)
                .AppendJoin(separator, nameof(UpdateMode), UpdateMode)
                .AppendJoin(separator, nameof(IsActive), IsActive())
                .AppendJoin(separator, nameof(IsPlaying), IsPlaying())
                .AppendJoin(separator, nameof(IsRewinding), IsRewinding())
                .AppendJoin(separator, nameof(IsPaused), IsPaused())
                .AppendJoin(separator, nameof(IsStopped), IsStopped())
                .ToString();
        }
    }
}