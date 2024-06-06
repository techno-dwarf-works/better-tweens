using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioDistortionFilterExtensions
    {
        public static LevelAudioDistortionFilterTween TweenLevel(this AudioDistortionFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LevelAudioDistortionFilterTween, AudioDistortionFilter, float>(options, optionsMode);
        }

        public static IEnumerable<LevelAudioDistortionFilterTween> TweensLevel(this IEnumerable<AudioDistortionFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<LevelAudioDistortionFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLevel(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}