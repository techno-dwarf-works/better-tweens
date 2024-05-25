using System.Text;
using Better.Commons.Runtime.Extensions;

namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendFieldLine(nameof(Duration), Duration)
                .AppendFieldLine(nameof(LoopProgress), LoopProgress)
                .AppendFieldLine(nameof(LoopMode), LoopMode)
                .AppendFieldLine(nameof(Ease), Ease)
                .AppendFieldLine(nameof(InDelay), InDelay)
                .AppendFieldLine(nameof(RemainingDelay), RemainingDelay)
                .AppendFieldLine(nameof(StartDelay), StartDelay)
                .AppendFieldLine(nameof(LoopDelay), LoopDelay);
        }
    }
}