using System;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public class VirtualBoolTween : BoolTween
    {
        private Func<bool> _getter;
        private Action<bool> _setter;

        public VirtualBoolTween(Func<bool> getter, Action<bool> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override bool GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafe(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(bool value)
        {
            ActionUtility.TryInvokeBySafe(_setter, value);
        }
    }
}