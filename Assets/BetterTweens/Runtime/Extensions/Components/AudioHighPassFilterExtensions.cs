﻿using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioHighPassFilterExtensions
    {
        public static ResonanceAudioHighPassFilterTween TweenResonance(this AudioHighPassFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ResonanceAudioHighPassFilterTween, AudioHighPassFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ResonanceAudioHighPassFilterTween> TweensResonance(this IEnumerable<AudioHighPassFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ResonanceAudioHighPassFilterTween>();
            }

            var tweens = new List<ResonanceAudioHighPassFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenResonance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FrequencyAudioHighPassFilterTween TweenFrequency(this AudioHighPassFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrequencyAudioHighPassFilterTween, AudioHighPassFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FrequencyAudioHighPassFilterTween> TweensFrequency(this IEnumerable<AudioHighPassFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FrequencyAudioHighPassFilterTween>();
            }

            var tweens = new List<FrequencyAudioHighPassFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFrequency(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}