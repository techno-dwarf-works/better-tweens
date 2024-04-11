using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public class PauseState : TweenState
    {
        public override float DirectionMod => 0f;

        public override async Task EnterAsync(CancellationToken token)
        {
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

            Source.OnPaused();
        }
    }
}