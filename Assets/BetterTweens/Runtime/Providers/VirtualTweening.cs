using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class VirtualTweening
    {
        public static VirtualTween Tween(Action<float> evaluateAction)
        {
            return new VirtualTween(evaluateAction);
        }

        public static VirtualBoolTween Tween(Func<bool> getter, Action<bool> setter)
        {
            return new VirtualBoolTween(getter, setter);
        }

        public static VirtualColorTween Tween(Func<Color> getter, Action<Color> setter)
        {
            return new VirtualColorTween(getter, setter);
        }

        public static VirtualFloatTween Tween(Func<float> getter, Action<float> setter)
        {
            return new VirtualFloatTween(getter, setter);
        }

        public static VirtualIntTween Tween(Func<int> getter, Action<int> setter)
        {
            return new VirtualIntTween(getter, setter);
        }

        public static VirtualQuaternionTween Tween(Func<Quaternion> getter, Action<Quaternion> setter)
        {
            return new VirtualQuaternionTween(getter, setter);
        }

        public static VirtualVector2Tween Tween(Func<Vector2> getter, Action<Vector2> setter)
        {
            return new VirtualVector2Tween(getter, setter);
        }

        public static VirtualVector2IntTween Tween(Func<Vector2Int> getter, Action<Vector2Int> setter)
        {
            return new VirtualVector2IntTween(getter, setter);
        }

        public static VirtualVector3Tween Tween(Func<Vector3> getter, Action<Vector3> setter)
        {
            return new VirtualVector3Tween(getter, setter);
        }

        public static VirtualVector3IntTween Tween(Func<Vector3Int> getter, Action<Vector3Int> setter)
        {
            return new VirtualVector3IntTween(getter, setter);
        }

        public static VirtualVector4Tween Tween(Func<Vector4> getter, Action<Vector4> setter)
        {
            return new VirtualVector4Tween(getter, setter);
        }
    }
}