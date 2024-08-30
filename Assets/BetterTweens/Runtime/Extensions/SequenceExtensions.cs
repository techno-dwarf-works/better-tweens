using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class SequenceExtensions
    {
        public static Sequence PrependTweens(this Sequence self, IEnumerable<Tween> tweens)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(tweens))
            {
                return self;
            }

            foreach (var tween in tweens)
            {
                self.PrependTween(tween);
            }

            return self;
        }

        public static Sequence AppendTweens(this Sequence self, IEnumerable<Tween> tweens)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(tweens))
            {
                return self;
            }

            foreach (var tween in tweens)
            {
                self.AppendTween(tween);
            }

            return self;
        }

        public static Sequence JoinTweens(this Sequence self, IEnumerable<Tween> tweens)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(tweens))
            {
                return self;
            }

            foreach (var tween in tweens)
            {
                self.JoinTween(tween);
            }

            return self;
        }
    }
}