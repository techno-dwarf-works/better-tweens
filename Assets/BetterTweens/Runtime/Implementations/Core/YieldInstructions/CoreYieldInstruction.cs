using UnityEngine;

namespace Better.Tweens.Runtime
{
    internal abstract class CoreYieldInstruction : CustomYieldInstruction
    {
        protected TweenCore Source { get; }

        public CoreYieldInstruction(TweenCore source)
        {
            Source = source;
        }
    }

    // Started, Activated, Playing, Rewinding, Updated, Paused, Stopped, Completed, Rewound, LoopCompleted, LoopRewound
    // ProgressPassed(float), ElapsedLoops(int), RewoundedLoops(int)
}