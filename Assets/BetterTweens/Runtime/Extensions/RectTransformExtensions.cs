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

        public static AnchoredPositionRectTransformTween TweenAnchoredPosition(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchoredPositionRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPositionX(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<AnchoredPositionRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static AnchoredPositionRectTransformTween TweenAnchoredPositionY(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<AnchoredPositionRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static AnchorMaxRectTransformTween TweenAnchorMax(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchorMaxRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static AnchorMinRectTransformTween TweenAnchorMin(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AnchorMinRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static OffsetMaxRectTransformTween TweenOffsetMax(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<OffsetMaxRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static OffsetMinRectTransformTween TweenOffsetMin(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<OffsetMinRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static PivotRectTransformTween TweenPivot(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PivotRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static PivotRectTransformTween TweenPivotX(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PivotRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static PivotRectTransformTween TweenPivotY(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PivotRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static SizeDeltaRectTransformTween TweenSizeDelta(this RectTransform self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SizeDeltaRectTransformTween, RectTransform, Vector2>(options, optionsMode);
        }

        public static SizeDeltaRectTransformTween TweenSizeDeltaX(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeDeltaRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static SizeDeltaRectTransformTween TweenSizeDeltaY(this RectTransform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeDeltaRectTransformTween, RectTransform>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }
    }
}