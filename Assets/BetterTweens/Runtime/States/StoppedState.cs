﻿using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public class StoppedState : TweenState
    {
        private bool _suppressNotify;
        public override float ProgressMod => 0f;

        public StoppedState(TweenCore source) : base(source)
        {
        }

        public void SuppressNextNotify()
        {
            _suppressNotify = true;
        }

        public override async Task EnterAsync(CancellationToken token)
        {
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

            Source.RawProgress = default;
            TryNotify();
        }

        private void TryNotify()
        {
            if (_suppressNotify)
            {
                _suppressNotify = false;
                return;
            }

            Source.OnStopped();
        }
    }
}