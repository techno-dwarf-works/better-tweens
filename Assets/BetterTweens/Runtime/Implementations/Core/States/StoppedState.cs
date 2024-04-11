using System.Threading;
using System.Threading.Tasks;

namespace Better.Tweens.Runtime
{
    public class StoppedState : TweenState
    {
        private bool _suppressNotify;
        public override float DirectionMod => 0f;
        
        public void SuppressNextNotify()
        {
            _suppressNotify = true;
        }

        public override async Task EnterAsync(CancellationToken token)
        {
            await base.EnterAsync(token);
            if (token.IsCancellationRequested) return;

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