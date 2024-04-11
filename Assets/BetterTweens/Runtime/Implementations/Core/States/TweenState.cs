using System.Threading;
using System.Threading.Tasks;
using Better.StateMachine.Runtime.States;

namespace Better.Tweens.Runtime
{
    public abstract class TweenState : BaseState
    {
        protected TweenCore Source { get; private set; }
        public abstract float DirectionMod { get; }

        public virtual void Setup(TweenCore source)
        {
            Source = source;
        }

        public override Task EnterAsync(CancellationToken token)
        {
            return Task.CompletedTask;
        }

        public override Task ExitAsync(CancellationToken token)
        {
            return Task.CompletedTask;
        }
    }
}