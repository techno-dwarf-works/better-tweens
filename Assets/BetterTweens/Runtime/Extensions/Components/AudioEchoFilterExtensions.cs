using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioEchoFilterExtensions
    {
        public static DecayRatioAudioEchoFilterTween TweenDecayRatio(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayRatioAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DecayRatioAudioEchoFilterTween> TweensDecayRatio(this IEnumerable<AudioEchoFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DecayRatioAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDecayRatio(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DelayAudioEchoFilterTween TweenDelay(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DelayAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DelayAudioEchoFilterTween> TweensDelay(this IEnumerable<AudioEchoFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DelayAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDelay(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DryMixAudioEchoFilterTween TweenDryMix(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DryMixAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DryMixAudioEchoFilterTween> TweensDryMix(this IEnumerable<AudioEchoFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DryMixAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDryMix(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WetMixAudioEchoFilterTween TweenWetMix(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMixAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }

        public static IEnumerable<WetMixAudioEchoFilterTween> TweensWetMix(this IEnumerable<AudioEchoFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WetMixAudioEchoFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWetMix(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}