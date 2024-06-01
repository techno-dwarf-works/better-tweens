using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VirtualVector2IntTween : Vector2IntTween
    {
        private Func<Vector2Int> _getter;
        private Action<Vector2Int> _setter;

        public VirtualVector2IntTween(Func<Vector2Int> getter, Action<Vector2Int> setter)
        {
            _getter = getter;
            _setter = setter;
        }

        protected override Vector2 GetCurrentValue()
        {
            if (FuncUtility.TryInvokeBySafe(_getter, out var result))
            {
                return result;
            }

            return default;
        }

        protected override void SetCurrentValue(Vector2Int value)
        {
            ActionUtility.TryInvokeBySafe(_setter, value);
        }
    }
}