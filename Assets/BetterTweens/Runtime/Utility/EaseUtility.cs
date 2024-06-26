﻿using System;

namespace Better.Tweens.Runtime.Utility
{
    public static class EaseUtility
    {
        public static Ease GetEaseByType(EaseType type, EaseMode mode = EaseMode.InOut)
        {
            return type switch
            {
                EaseType.Linear => new LinearEase(),
                EaseType.Power => new PowerEase(mode),
                EaseType.Sine => new SineEase(mode),
                EaseType.Quad => new QuadEase(mode),
                EaseType.Cubic => new CubicEase(mode),
                EaseType.Quart => new QuartEase(mode),
                EaseType.Quint => new QuintEase(mode),
                EaseType.Expo => new ExpoEase(mode),
                EaseType.Circ => new CircEase(mode),
                EaseType.Elastic => new ElasticEase(mode),
                EaseType.Back => new BackEase(mode),
                EaseType.Bounce => new BounceEase(mode),
                EaseType.Flash => new FlashEase(mode),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}