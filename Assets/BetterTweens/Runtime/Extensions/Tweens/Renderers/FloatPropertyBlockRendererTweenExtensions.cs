using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class FloatPropertyBlockRendererTweenExtensions
    {
        public static IEnumerable<FloatPropertyBlockRendererTween> SetPropertyName(this IEnumerable<FloatPropertyBlockRendererTween> self, string propertyName)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetPropertyName(propertyName);
            }

            return self;
        }
    }
}