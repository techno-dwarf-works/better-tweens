using System;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime.Sequences.Stages
{
    public class ActionStage : SimpleStage
    {
        private Action _action;

        public void On(Action action)
        {
            _action += action;
        }

        protected override void Execute()
        {
            ActionUtility.TryInvokeBySafeMode(_action);
        }

        public override Stage Clone()
        {
            var clone = new ActionStage();
            clone._action = _action;
            
            return clone;
        }
    }
}