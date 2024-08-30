using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VirtualColorTween : ColorTween
    {
        private Func<Color> _getter;
        private Action<Color> _setter;

        public VirtualColorTween(Func<Color> getter, Action<Color> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override Color GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafeMode(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(Color value)
        {
            ActionUtility.TryInvokeBySafeMode(_setter, value);
        }
    }
}