using System;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;

namespace Better.Tweens.Runtime
{
    public static class EaseUtility
    {
        public static Ease GetEaseByType(EaseType type, EaseMode mode = EaseMode.InOut)
        {
            // TODO: Add pooling

            return type switch
            {
                EaseType.Linear => new LinearEase(),
                EaseType.Power => new PowerEase(mode),
                EaseType.Sine => new SineEase(mode),
                EaseType.Quad => new QuadEase(mode),
                EaseType.Cubic => new CubicEase(mode),
                EaseType.Quart => new QuartEase(mode),
                EaseType.Quint => new QuintEase(mode),
                EaseType.Expo => new QuintEase(mode),
                EaseType.Circ => new QuintEase(mode),
                EaseType.Elastic => new QuintEase(mode),
                EaseType.Back => new QuintEase(mode),
                EaseType.Bounce => new QuintEase(mode),
                EaseType.Flash => new QuintEase(mode),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}