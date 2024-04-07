using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public class PlayingState : ActiveState
    {
        private bool _startTrigger;
        public override float ProgressMod => 1f;

        public override async Task EnterAsync(CancellationToken token)
        {
            OnPreEnter();
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

            Source.OnPlay();
        }

        private void OnPreEnter()
        {
            if (_startTrigger)
            {
                _startTrigger = false;
                Source.OnStarted();
            }
        }

        public void MarkStartTrigger()
        {
            _startTrigger = true;
        }
    }
}