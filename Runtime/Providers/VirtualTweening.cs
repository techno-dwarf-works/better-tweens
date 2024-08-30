using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class VirtualTweening
    {
        public static VirtualTween Tween(Action<float> evaluateAction, float duration)
        {
            var tween = new VirtualTween(evaluateAction);
            tween.SetDuration(duration);

            return tween;
        }

        public static VirtualBoolTween Tween(Func<bool> getter, Action<bool> setter, float duration, bool options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualBoolTween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualColorTween Tween(Func<Color> getter, Action<Color> setter, float duration, Color options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualColorTween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualFloatTween Tween(Func<float> getter, Action<float> setter, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualFloatTween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualIntTween Tween(Func<int> getter, Action<int> setter, float duration, int options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualIntTween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualQuaternionTween Tween(Func<Quaternion> getter, Action<Quaternion> setter, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualQuaternionTween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualVector2Tween Tween(Func<Vector2> getter, Action<Vector2> setter, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualVector2Tween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualVector2IntTween Tween(Func<Vector2Int> getter, Action<Vector2Int> setter, float duration, Vector2Int options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualVector2IntTween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualVector3Tween Tween(Func<Vector3> getter, Action<Vector3> setter, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualVector3Tween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualVector3IntTween Tween(Func<Vector3Int> getter, Action<Vector3Int> setter, float duration, Vector3Int options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualVector3IntTween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static VirtualVector4Tween Tween(Func<Vector4> getter, Action<Vector4> setter, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            var tween = new VirtualVector4Tween(getter, setter);
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }
    }
}