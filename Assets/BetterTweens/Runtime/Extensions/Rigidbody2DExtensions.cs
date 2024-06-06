using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class Rigidbody2DExtensions
    {
        public static AngularDragRigidbody2DTween TweenAngularDrag(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularDragRigidbody2DTween, Rigidbody2D, float>(options, optionsMode);
        }

        public static AngularVelocityRigidbody2DTween TweenAngularVelocity(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularVelocityRigidbody2DTween, Rigidbody2D, float>(options, optionsMode);
        }

        public static CenterOfMassRigidbody2DTween TweenCenterOfMass(this Rigidbody2D self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<CenterOfMassRigidbody2DTween, Rigidbody2D, Vector2>(options, optionsMode);
        }

        public static DragRigidbody2DTween TweenDrag(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DragRigidbody2DTween, Rigidbody2D, float>(options, optionsMode);
        }

        public static InertiaRigidbody2DTween TweenInertia(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaRigidbody2DTween, Rigidbody2D, float>(options, optionsMode);
        }

        public static KinematicRigidbody2DTween TweenKinematic(this Rigidbody2D self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<KinematicRigidbody2DTween, Rigidbody2D, bool>(options, optionsMode);
        }

        public static MassRigidbody2DTween TweenMass(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MassRigidbody2DTween, Rigidbody2D, float>(options, optionsMode);
        }

        public static PositionRigidbody2DTween TweenPosition(this Rigidbody2D self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionRigidbody2DTween, Rigidbody2D, Vector2>(options, optionsMode);
        }

        public static PositionRigidbody2DTween TweenPositionX(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PositionRigidbody2DTween, Rigidbody2D>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static PositionRigidbody2DTween TweenPositionY(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PositionRigidbody2DTween, Rigidbody2D>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static RotationRigidbody2DTween TweenRotation(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RotationRigidbody2DTween, Rigidbody2D, float>(options, optionsMode);
        }

        public static GravityScaleRigidbody2DTween TweenGravityScale(this Rigidbody2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<GravityScaleRigidbody2DTween, Rigidbody2D, float>(options, optionsMode);
        }

        public static VelocityRigidbody2DTween TweenVelocity(this Rigidbody2D self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<VelocityRigidbody2DTween, Rigidbody2D, Vector2>(options, optionsMode);
        }
    }
}