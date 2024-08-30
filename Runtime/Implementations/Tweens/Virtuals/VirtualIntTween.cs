using System;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public class VirtualIntTween : IntTween
    {
        private Func<int> _getter;
        private Action<int> _setter;

        public VirtualIntTween(Func<int> getter, Action<int> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override int GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafeMode(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(int value)
        {
            ActionUtility.TryInvokeBySafeMode(_setter, value);
        }
    }
}