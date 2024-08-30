using System.Threading;
using System.Threading.Tasks;
using Better.Commons.Runtime.Extensions;

namespace Better.Tweens.Runtime
{
    public partial class Sequence
    {
        protected internal override void OnStarted()
        {
            RestartOperationToken();
            _rootChannel.Start();

            base.OnStarted();
        }

        protected internal override void OnPlay()
        {
            var token = RestartOperationToken();
            PlayChannelAsync(token).Forget();

            base.OnPlay();
        }

        private async Task PlayChannelAsync(CancellationToken cancellationToken)
        {
            for (int i = CompletedLoops; i < LoopCount; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                await _rootChannel.PlayAsync(cancellationToken);
                if (!cancellationToken.IsCancellationRequested)
                {
                    InstantCompleteLoop();
                }
            }
        }

        protected internal override void OnRewind()
        {
            var token = RestartOperationToken();
            RewindChannelAsync(token).Forget();

            base.OnRewind();
        }

        private async Task RewindChannelAsync(CancellationToken cancellationToken)
        {
            for (int i = CompletedLoops; i >= 0; i--)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                await _rootChannel.RewindAsync(cancellationToken);
                if (!cancellationToken.IsCancellationRequested)
                {
                    InstantRewoundLoop();
                }
            }
        }

        protected internal override void OnPaused()
        {
            RestartOperationToken();
            _rootChannel.Pause();

            base.OnPaused();
        }

        protected internal override void OnStopped()
        {
            RestartOperationToken();
            _rootChannel.Stop();

            base.OnStopped();
        }

        private CancellationToken RestartOperationToken()
        {
            _operationTokenSource?.Cancel();
            _operationTokenSource = new();

            return _operationTokenSource.Token;
        }
    }
}