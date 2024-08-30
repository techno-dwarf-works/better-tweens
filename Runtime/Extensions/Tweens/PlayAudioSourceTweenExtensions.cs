using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class PlayAudioSourceTweenExtensions
    {
        public static IEnumerable<PlayAudioSourceTween> SetOnce(this IEnumerable<PlayAudioSourceTween> self, bool once = true)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetOnce(once);
            }

            return self;
        }
    }
}