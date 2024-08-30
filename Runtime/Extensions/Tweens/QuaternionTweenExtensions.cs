using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class QuaternionTweenExtensions
    {
        public static IEnumerable<QuaternionTween> SetSpherical(this IEnumerable<QuaternionTween> self, bool spherical = true)
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

        public static IEnumerable<QuaternionTween<TTarget>> SetSpherical<TTarget>(this IEnumerable<QuaternionTween<TTarget>> self, bool spherical = true)
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
    }
}