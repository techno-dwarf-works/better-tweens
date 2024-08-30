using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class VectorTweenExtensions
    {
        public static IEnumerable<VectorTween<TVector, TConstraint>> SetSpherical<TVector, TConstraint>(this IEnumerable<VectorTween<TVector, TConstraint>> self, bool spherical = true)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetSpherical(spherical);
            }

            return self;
        }

        public static IEnumerable<VectorTween<TTarget, TVector, TConstraint>> SetSpherical<TTarget, TVector, TConstraint>(this IEnumerable<VectorTween<TTarget, TVector, TConstraint>> self, bool spherical = true)
            where TTarget : class
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetSpherical(spherical);
            }

            return self;
        }

        public static IEnumerable<VectorTween<TVector, TConstraint>> AddConstraint<TVector, TConstraint>(this IEnumerable<VectorTween<TVector, TConstraint>> self, TConstraint constraint)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.AddConstraint(constraint);
            }

            return self;
        }

        public static IEnumerable<VectorTween<TTarget, TVector, TConstraint>> AddConstraint<TTarget, TVector, TConstraint>(this IEnumerable<VectorTween<TTarget, TVector, TConstraint>> self, TConstraint constraint)
            where TTarget : class
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.AddConstraint(constraint);
            }

            return self;
        }

        public static IEnumerable<VectorTween<TVector, TConstraint>> RemoveConstraint<TVector, TConstraint>(this IEnumerable<VectorTween<TVector, TConstraint>> self, TConstraint constraint)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.RemoveConstraint(constraint);
            }

            return self;
        }

        public static IEnumerable<VectorTween<TTarget, TVector, TConstraint>> RemoveConstraint<TTarget, TVector, TConstraint>(this IEnumerable<VectorTween<TTarget, TVector, TConstraint>> self, TConstraint constraint)
            where TTarget : class
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.RemoveConstraint(constraint);
            }

            return self;
        }
    }
}