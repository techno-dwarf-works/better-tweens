using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class PropertyTextureScaleMaterialTweenExtensions
    {
        public static IEnumerable<PropertyTextureScaleMaterialTween> SetPropertyName(this IEnumerable<PropertyTextureScaleMaterialTween> self, string propertyName)
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