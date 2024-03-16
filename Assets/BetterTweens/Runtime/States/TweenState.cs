using System.Threading;
using System.Threading.Tasks;
using Better.StateMachine.Runtime.States;

namespace Better.Tweens.Runtime
{
    public abstract class TweenState : BaseState
    {
        protected Tween Source { get; private set; }

        public TweenState(Tween source)
        {
            Source = source;
        }

        public override Task EnterAsync(CancellationToken token)
        {
            return Task.CompletedTask;
        }

        public virtual void ApplyProgress(float value)
        {
        }

        public override Task ExitAsync(CancellationToken token)
        {
            return Task.CompletedTask;
        }
    }
}