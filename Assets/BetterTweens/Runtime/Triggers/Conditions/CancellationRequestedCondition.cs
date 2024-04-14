using System.Threading;

namespace Better.Tweens.Runtime.Triggers
{
    public class CancellationRequestedCondition : TriggerCondition<CancellationToken>
    {
        private readonly bool _cancelled;

        public CancellationRequestedCondition(CancellationToken source, bool cancelled = true) : base(source)
        {
            _cancelled = cancelled;
        }

        public override bool Validate()
        {
            return Source.IsCancellationRequested == _cancelled;
        }
    }
}