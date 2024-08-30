using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VirtualVector2Tween : Vector2Tween
    {
        private Func<Vector2> _getter;
        private Action<Vector2> _setter;

        public VirtualVector2Tween(Func<Vector2> getter, Action<Vector2> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override Vector2 GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafeMode(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            ActionUtility.TryInvokeBySafeMode(_setter, value);
        }
    }
}