using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class PropertyIntegerMaterialTweenExtensions
    {
        public static IEnumerable<PropertyIntegerMaterialTween> SetPropertyName(this IEnumerable<PropertyIntegerMaterialTween> self, string propertyName)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
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