using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class PropertyColorMaterialTweenExtensions
    {
        public static IEnumerable<PropertyColorMaterialTween> SetPropertyName(this IEnumerable<PropertyColorMaterialTween> self, string propertyName)
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