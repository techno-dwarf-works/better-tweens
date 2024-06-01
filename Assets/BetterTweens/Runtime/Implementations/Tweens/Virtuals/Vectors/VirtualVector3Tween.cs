using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VirtualVector3Tween : Vector3Tween
    {
        private Func<Vector3> _getter;
        private Action<Vector3> _setter;

        public VirtualVector3Tween(Func<Vector3> getter, Action<Vector3> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override Vector3 GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafe(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            ActionUtility.TryInvokeBySafe(_setter, value);
        }
    }
}