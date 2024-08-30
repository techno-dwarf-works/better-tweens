using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioLowPassFilterExtensions
    {
        public static ResonanceAudioLowPassFilterTween TweenResonance(this AudioLowPassFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ResonanceAudioLowPassFilterTween, AudioLowPassFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ResonanceAudioLowPassFilterTween> TweensResonance(this IEnumerable<AudioLowPassFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ResonanceAudioLowPassFilterTween>();
            }

            var tweens = new List<ResonanceAudioLowPassFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenResonance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FrequencyAudioLowPassFilterTween TweenFrequency(this AudioLowPassFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrequencyAudioLowPassFilterTween, AudioLowPassFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FrequencyAudioLowPassFilterTween> TweensFrequency(this IEnumerable<AudioLowPassFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FrequencyAudioLowPassFilterTween>();
            }

            var tweens = new List<FrequencyAudioLowPassFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFrequency(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}