using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public abstract class ActiveState : TweenState
    {
        public override async Task EnterAsync(CancellationToken token)
        {
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

            TweenRegistry.Register(Source);
            Source.OnActive();
        }

        public override async Task ExitAsync(CancellationToken token)
        {
            await base.ExitAsync(token);
            if (token.IsCancellationRequested) return;

            TweenRegistry.Unregister(Source);
        }
    }
}