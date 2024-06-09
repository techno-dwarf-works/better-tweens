using System;
using System.Collections.Generic;

namespace Better.Tweens.Runtime
{
    public static class SystemObjectExtensions
    {
        public static void TweensTagged(this object self, ref ICollection<TweenCore> references)
        {
            if (references == null)
            {
                throw new ArgumentNullException(nameof(references));
            }

            foreach (var tweenCore in TweenRegistry.Elements)
            {
                if (tweenCore.ContainsTag(self))
                {
                    references.Add(tweenCore);
                }
            }
        }

        public static ICollection<TweenCore> TweensTagged(this object self)
        {
            ICollection<TweenCore> references = new List<TweenCore>();
            TweensTagged(self, ref references);

            return references;
        }
    }
}