using System.Collections.Generic;
using Better.Commons.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class RectTransformExtensions
    {
        public static AnchoredPosition3DRectTransformTween TweenAnchoredPosition3D(this RectTransform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchoredPosition3DRectTransformTween, RectTransform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<AnchoredPosition3DRectTransformTween> TweensAnchoredPosition3D(this IEnumerable<RectTransform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AnchoredPosition3DRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPosition3D(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPosition(this RectTransform self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchoredPositionRectTransformTween, RectTransform, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<AnchoredPositionRectTransformTween> TweensAnchoredPosition(this IEnumerable<RectTransform> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AnchoredPositionRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPositionX(this RectTransform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<AnchoredPositionRectTransformTween, RectTransform>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.Y);

            return tween;
        }

        public static IEnumerable<AnchoredPositionRectTransformTween> TweensAnchoredPositionX(this IEnumerable<RectTransform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AnchoredPositionRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPositionX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPositionY(this RectTransform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<AnchoredPositionRectTransformTween, RectTransform>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.X);

            return tween;
        }

        public static IEnumerable<AnchoredPositionRectTransformTween> TweensAnchoredPositionY(this IEnumerable<RectTransform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AnchoredPositionRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPositionY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchorMaxRectTransformTween TweenAnchorMax(this RectTransform self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchorMaxRectTransformTween, RectTransform, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<AnchorMaxRectTransformTween> TweensAnchorMax(this IEnumerable<RectTransform> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AnchorMaxRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchorMax(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchorMinRectTransformTween TweenAnchorMin(this RectTransform self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchorMinRectTransformTween, RectTransform, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<AnchorMinRectTransformTween> TweensAnchorMin(this IEnumerable<RectTransform> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AnchorMinRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchorMin(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OffsetMaxRectTransformTween TweenOffsetMax(this RectTransform self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<OffsetMaxRectTransformTween, RectTransform, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<OffsetMaxRectTransformTween> TweensOffsetMax(this IEnumerable<RectTransform> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<OffsetMaxRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOffsetMax(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OffsetMinRectTransformTween TweenOffsetMin(this RectTransform self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<OffsetMinRectTransformTween, RectTransform, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<OffsetMinRectTransformTween> TweensOffsetMin(this IEnumerable<RectTransform> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<OffsetMinRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOffsetMin(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PivotRectTransformTween TweenPivot(this RectTransform self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PivotRectTransformTween, RectTransform, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<PivotRectTransformTween> TweensPivot(this IEnumerable<RectTransform> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PivotRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPivot(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PivotRectTransformTween TweenPivotX(this RectTransform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PivotRectTransformTween, RectTransform>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.Y);

            return tween;
        }

        public static IEnumerable<PivotRectTransformTween> TweensPivotX(this IEnumerable<RectTransform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PivotRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPivotX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PivotRectTransformTween TweenPivotY(this RectTransform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PivotRectTransformTween, RectTransform>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.X);

            return tween;
        }

        public static IEnumerable<PivotRectTransformTween> TweensPivotY(this IEnumerable<RectTransform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PivotRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPivotY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeDeltaRectTransformTween TweenSizeDelta(this RectTransform self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SizeDeltaRectTransformTween, RectTransform, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<SizeDeltaRectTransformTween> TweensSizeDelta(this IEnumerable<RectTransform> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<SizeDeltaRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeDelta(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeDeltaRectTransformTween TweenSizeDeltaX(this RectTransform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeDeltaRectTransformTween, RectTransform>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.Y);

            return tween;
        }

        public static IEnumerable<SizeDeltaRectTransformTween> TweensSizeDeltaX(this IEnumerable<RectTransform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<SizeDeltaRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeDeltaX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeDeltaRectTransformTween TweenSizeDeltaY(this RectTransform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeDeltaRectTransformTween, RectTransform>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.X);

            return tween;
        }

        public static IEnumerable<SizeDeltaRectTransformTween> TweensSizeDeltaY(this IEnumerable<RectTransform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<SizeDeltaRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeDeltaY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}