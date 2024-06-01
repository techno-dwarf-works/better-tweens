using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Utility
{
    public static class VirtualTweening
    {
        public static VirtualTween Create(Action<float> evaluateAction)
        {
            return new VirtualTween(evaluateAction);
        }

        public static VirtualBoolTween Create(Func<bool> getter, Action<bool> setter)
        {
            return new VirtualBoolTween(getter, setter);
        }

        public static VirtualColorTween Create(Func<Color> getter, Action<Color> setter)
        {
            return new VirtualColorTween(getter, setter);
        }

        public static VirtualFloatTween Create(Func<float> getter, Action<float> setter)
        {
            return new VirtualFloatTween(getter, setter);
        }

        public static VirtualIntTween Create(Func<int> getter, Action<int> setter)
        {
            return new VirtualIntTween(getter, setter);
        }

        public static VirtualQuaternionTween Create(Func<Quaternion> getter, Action<Quaternion> setter)
        {
            return new VirtualQuaternionTween(getter, setter);
        }

        public static VirtualVector2Tween Create(Func<Vector2> getter, Action<Vector2> setter)
        {
            return new VirtualVector2Tween(getter, setter);
        }

        public static VirtualVector2IntTween Create(Func<Vector2Int> getter, Action<Vector2Int> setter)
        {
            return new VirtualVector2IntTween(getter, setter);
        }

        public static VirtualVector3Tween Create(Func<Vector3> getter, Action<Vector3> setter)
        {
            return new VirtualVector3Tween(getter, setter);
        }

        public static VirtualVector3IntTween Create(Func<Vector3Int> getter, Action<Vector3Int> setter)
        {
            return new VirtualVector3IntTween(getter, setter);
        }

        public static VirtualVector4Tween Create(Func<Vector4> getter, Action<Vector4> setter)
        {
            return new VirtualVector4Tween(getter, setter);
        }
    }
}