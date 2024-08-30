using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class ColorTweenExtensions
    {
        public static IEnumerable<ColorTween> SetIgnoreAlpha(this IEnumerable<ColorTween> self, bool ignored = true)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetIgnoreAlpha(ignored);
            }

            return self;
        }

        public static IEnumerable<ColorTween<TTarget>> SetIgnoreAlpha<TTarget>(this IEnumerable<ColorTween<TTarget>> self, bool ignored = true)
            where TTarget : class
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetIgnoreAlpha(ignored);
            }

            return self;
        }
    }
}