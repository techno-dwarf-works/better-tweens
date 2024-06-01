using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VirtualQuaternionTween : QuaternionTween
    {
        private Func<Quaternion> _getter;
        private Action<Quaternion> _setter;

        public VirtualQuaternionTween(Func<Quaternion> getter, Action<Quaternion> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override Quaternion GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafe(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(Quaternion value)
        {
            ActionUtility.TryInvokeBySafe(_setter, value);
        }
    }
}