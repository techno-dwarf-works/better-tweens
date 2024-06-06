using System.Collections.Generic;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class RectTransformExtensions
    {
        public static AnchoredPosition3DRectTransformTween TweenAnchoredPosition3D(this RectTransform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchoredPosition3DRectTransformTween, RectTransform, Vector3>(options, optionsMode);
        }

        public static IEnumerable<AnchoredPosition3DRectTransformTween> TweensAnchoredPosition3D(this IEnumerable<RectTransform> self, Vector3 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AnchoredPosition3DRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPosition3D(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPosition(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchoredPositionRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static IEnumerable<AnchoredPositionRectTransformTween> TweensAnchoredPosition(this IEnumerable<RectTransform> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AnchoredPositionRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPosition(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPositionX(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<AnchoredPositionRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static IEnumerable<AnchoredPositionRectTransformTween> TweensAnchoredPositionX(this IEnumerable<RectTransform> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AnchoredPositionRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPositionX(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPositionY(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<AnchoredPositionRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static IEnumerable<AnchoredPositionRectTransformTween> TweensAnchoredPositionY(this IEnumerable<RectTransform> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AnchoredPositionRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchoredPositionY(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchorMaxRectTransformTween TweenAnchorMax(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchorMaxRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static IEnumerable<AnchorMaxRectTransformTween> TweensAnchorMax(this IEnumerable<RectTransform> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AnchorMaxRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchorMax(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AnchorMinRectTransformTween TweenAnchorMin(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchorMinRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static IEnumerable<AnchorMinRectTransformTween> TweensAnchorMin(this IEnumerable<RectTransform> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AnchorMinRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAnchorMin(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OffsetMaxRectTransformTween TweenOffsetMax(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<OffsetMaxRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static IEnumerable<OffsetMaxRectTransformTween> TweensOffsetMax(this IEnumerable<RectTransform> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<OffsetMaxRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOffsetMax(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OffsetMinRectTransformTween TweenOffsetMin(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<OffsetMinRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static IEnumerable<OffsetMinRectTransformTween> TweensOffsetMin(this IEnumerable<RectTransform> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<OffsetMinRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOffsetMin(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PivotRectTransformTween TweenPivot(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PivotRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static IEnumerable<PivotRectTransformTween> TweensPivot(this IEnumerable<RectTransform> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PivotRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPivot(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PivotRectTransformTween TweenPivotX(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PivotRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static IEnumerable<PivotRectTransformTween> TweensPivotX(this IEnumerable<RectTransform> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PivotRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPivotX(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PivotRectTransformTween TweenPivotY(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PivotRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static IEnumerable<PivotRectTransformTween> TweensPivotY(this IEnumerable<RectTransform> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PivotRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPivotY(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeDeltaRectTransformTween TweenSizeDelta(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SizeDeltaRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static IEnumerable<SizeDeltaRectTransformTween> TweensSizeDelta(this IEnumerable<RectTransform> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeDeltaRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeDelta(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeDeltaRectTransformTween TweenSizeDeltaX(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeDeltaRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static IEnumerable<SizeDeltaRectTransformTween> TweensSizeDeltaX(this IEnumerable<RectTransform> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeDeltaRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeDeltaX(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeDeltaRectTransformTween TweenSizeDeltaY(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeDeltaRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static IEnumerable<SizeDeltaRectTransformTween> TweensSizeDeltaY(this IEnumerable<RectTransform> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeDeltaRectTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeDeltaY(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}