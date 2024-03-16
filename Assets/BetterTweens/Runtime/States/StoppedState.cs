using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public class StoppedState : TweenState
    {
        public StoppedState(Tween source) : base(source)
        {
        }

        public override async Task EnterAsync(CancellationToken token)
        {
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

            Source.Progress = default;
        }
    }
}