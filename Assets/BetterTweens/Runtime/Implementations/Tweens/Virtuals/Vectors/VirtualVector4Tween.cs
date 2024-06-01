using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VirtualVector4Tween : Vector4Tween
    {
        private Func<Vector4> _getter;
        private Action<Vector4> _setter;

        public VirtualVector4Tween(Func<Vector4> getter, Action<Vector4> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override Vector4 GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafe(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(Vector4 value)
        {
            ActionUtility.TryInvokeBySafe(_setter, value);
        }
    }
}