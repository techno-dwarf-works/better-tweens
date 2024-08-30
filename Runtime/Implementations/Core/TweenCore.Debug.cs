using System.Text;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public virtual void CollectInfo(ref StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine(GetType().Name)
                .AppendFieldLine(nameof(Initialized), Initialized)
                .AppendFieldLine("Activity State", _activityMachine?.CurrentState)
                .AppendFieldLine("Handling State", _handlingMachine?.CurrentState)
                .AppendFieldLine(nameof(IsBroken), IsBroken())
                .AppendLine()
                .AppendFieldLine(nameof(LoopCount), LoopCount)
                .AppendFieldLine(nameof(InfinityLoops), InfinityLoops)
                .AppendFieldLine(nameof(CompletedLoops), CompletedLoops)
                .AppendLine()
                .AppendFieldLine(nameof(SleepingDuration), SleepingDuration)
                .AppendFieldLine(nameof(InfinitySleeping), InfinitySleeping)
                .AppendLine()
                .AppendFieldLine(nameof(UpdateMode), UpdateMode)
                .AppendFieldLine(nameof(LocalTimeScale), LocalTimeScale)
                .AppendFieldLine(nameof(DependUnityTimeScale), DependUnityTimeScale)
                .AppendFieldLine(nameof(DependGlobalTimeScale), DependGlobalTimeScale)
                .AppendLine()
                .AppendFieldLine(nameof(CompletionAction), CompletionAction)
                .AppendFieldLine(nameof(RewoundAction), RewoundAction)
                .AppendLine()
                .AppendFieldLine("Triggers Count", _triggers?.Count)
                .AppendFieldLine("Tags Count", _tags?.Count);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            CollectInfo(ref stringBuilder);

            return stringBuilder.ToString();
        }
    }
}