using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioLowPassFilterExtensions
    {
        public static ResonanceAudioLowPassFilterTween TweenResonance(this AudioLowPassFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ResonanceAudioLowPassFilterTween, AudioLowPassFilter, float>(options, optionsMode);
        }

        public static IEnumerable<ResonanceAudioLowPassFilterTween> TweensResonance(this IEnumerable<AudioLowPassFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ResonanceAudioLowPassFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenResonance(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FrequencyAudioLowPassFilterTween TweenFrequency(this AudioLowPassFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrequencyAudioLowPassFilterTween, AudioLowPassFilter, float>(options, optionsMode);
        }

        public static IEnumerable<FrequencyAudioLowPassFilterTween> TweensFrequency(this IEnumerable<AudioLowPassFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FrequencyAudioLowPassFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFrequency(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}