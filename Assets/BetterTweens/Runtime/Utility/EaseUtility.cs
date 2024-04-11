using System;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;

namespace Better.Tweens.Runtime
{
    public static class EaseUtility
    {
        public static Ease GetEaseByType(EaseType type)
        {
            // TODO: Add pooling
            
            return type switch
            {
                EaseType.Linear => new LinearEase(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}