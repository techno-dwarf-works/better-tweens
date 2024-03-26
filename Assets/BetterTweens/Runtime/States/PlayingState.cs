using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public class PlayingState : ActiveState
    {
        public override float ProgressMod => 1f;

        public PlayingState(TweenCore source) : base(source)
        {
        }

        public override async Task EnterAsync(CancellationToken token)
        {
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

            Source.OnPlay();
        }
    }
}