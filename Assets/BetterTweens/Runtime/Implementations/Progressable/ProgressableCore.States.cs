﻿using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        protected internal override void OnStarted()
        {
            RemainingDelay = StartDelay;
            LoopProgress = 0f;
            EvaluateStateByLoop(LoopProgress);
            
            base.OnStarted();

            if (IsRunning() && InfinityLoops && Duration <= TweensSettings.MinTime)
            {
                var message = $"Cannot started with {nameof(InfinityLoops)} and {nameof(Duration)} less of {nameof(TweensSettings.MinTime)}({TweensSettings.MinTime}), will be {nameof(Stop)}";
                LogUtility.LogWarning(message);

                Stop();
            }
        }

        protected internal override void OnPlay()
        {
            _progressDirectionMod = PlayingProgressMod;

            base.OnPlay();

            if (IsPlaying() && Duration <= TweensSettings.MinTime)
            {
                InstantComplete();
            }
        }

        protected internal override void OnRewind()
        {
            _progressDirectionMod = RewindingProgressMod;

            base.OnRewind();

            if (IsRewinding() && Duration <= TweensSettings.MinTime)
            {
                InstantRewound();
            }
        }

        protected override void OnCompleted()
        {
            RemainingDelay = 0f;
            LoopProgress = 0f;

            base.OnCompleted();
        }

        protected override void OnRewound()
        {
            RemainingDelay = StartDelay;
            LoopProgress = 0f;

            base.OnRewound();
        }
    }
}