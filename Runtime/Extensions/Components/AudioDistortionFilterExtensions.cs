using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioDistortionFilterExtensions
    {
        public static LevelAudioDistortionFilterTween TweenLevel(this AudioDistortionFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LevelAudioDistortionFilterTween, AudioDistortionFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<LevelAudioDistortionFilterTween> TweensLevel(this IEnumerable<AudioDistortionFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LevelAudioDistortionFilterTween>();
            }

            var tweens = new List<LevelAudioDistortionFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLevel(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}