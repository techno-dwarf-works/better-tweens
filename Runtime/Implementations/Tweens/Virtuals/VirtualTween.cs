using System;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public class VirtualTween : Tween
    {
        private Action<float> _evaluateAction;

        public VirtualTween(Action<float> evaluateAction)
        {
            _evaluateAction = evaluateAction;
        }

        protected override void EvaluateState(float time)
        {
            ActionUtility.TryInvokeBySafeMode(_evaluateAction, time);
        }
    }
}