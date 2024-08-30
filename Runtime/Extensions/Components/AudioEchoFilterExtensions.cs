using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioEchoFilterExtensions
    {
        public static DecayRatioAudioEchoFilterTween TweenDecayRatio(this AudioEchoFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayRatioAudioEchoFilterTween, AudioEchoFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DecayRatioAudioEchoFilterTween> TweensDecayRatio(this IEnumerable<AudioEchoFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<DecayRatioAudioEchoFilterTween>();
            }

            var tweens = new List<DecayRatioAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDecayRatio(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DelayAudioEchoFilterTween TweenDelay(this AudioEchoFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DelayAudioEchoFilterTween, AudioEchoFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DelayAudioEchoFilterTween> TweensDelay(this IEnumerable<AudioEchoFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<DelayAudioEchoFilterTween>();
            }

            var tweens = new List<DelayAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDelay(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DryMixAudioEchoFilterTween TweenDryMix(this AudioEchoFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DryMixAudioEchoFilterTween, AudioEchoFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DryMixAudioEchoFilterTween> TweensDryMix(this IEnumerable<AudioEchoFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<DryMixAudioEchoFilterTween>();
            }

            var tweens = new List<DryMixAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDryMix(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WetMixAudioEchoFilterTween TweenWetMix(this AudioEchoFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMixAudioEchoFilterTween, AudioEchoFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<WetMixAudioEchoFilterTween> TweensWetMix(this IEnumerable<AudioEchoFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<WetMixAudioEchoFilterTween>();
            }

            var tweens = new List<WetMixAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWetMix(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}