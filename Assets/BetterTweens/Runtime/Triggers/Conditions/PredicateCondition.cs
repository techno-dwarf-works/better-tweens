using System;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime.Triggers
{
    public class PredicateCondition : TriggerCondition<Func<bool>>
    {
        public PredicateCondition(Func<bool> source) : base(source)
        {
        }

        public override bool Validate()
        {
            return FuncUtility.TryInvoke(Source, out var result) && result;
        }
    }
}