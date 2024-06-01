using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VirtualVector3IntTween : Vector3IntTween
    {
        private Func<Vector3Int> _getter;
        private Action<Vector3Int> _setter;

        public VirtualVector3IntTween(Func<Vector3Int> getter, Action<Vector3Int> setter)
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

        protected override void SetCurrentValue(Vector3Int value)
        {
            ActionUtility.TryInvokeBySafe(_setter, value);
        }
    }
}