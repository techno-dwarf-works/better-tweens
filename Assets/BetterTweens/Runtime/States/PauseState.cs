﻿using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public class PauseState : TweenState
    {
        public override float ProgressMod => 0f;

        public PauseState(TweenCore source) : base(source)
        {
        }

        public override async Task EnterAsync(CancellationToken token)
        {
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

            Source.OnPause();
        }
    }
}