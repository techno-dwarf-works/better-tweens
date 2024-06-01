using System;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public class VirtualFloatTween : FloatTween
    {
        private Func<float> _getter;
        private Action<float> _setter;

        public VirtualFloatTween(Func<float> getter, Action<float> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override float GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafe(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(float value)
        {
            ActionUtility.TryInvokeBySafe(_setter, value);
        }
    }
}