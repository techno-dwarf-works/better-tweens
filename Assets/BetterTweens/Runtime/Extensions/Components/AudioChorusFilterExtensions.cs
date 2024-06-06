using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioChorusFilterExtensions
    {
        public static DelayAudioChorusFilterTween TweenDelay(this AudioChorusFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DelayAudioChorusFilterTween, AudioChorusFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DelayAudioChorusFilterTween> TweensDelay(this IEnumerable<AudioChorusFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DelayAudioChorusFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDelay(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DepthAudioChorusFilterTween TweenDepth(this AudioChorusFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DepthAudioChorusFilterTween, AudioChorusFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DepthAudioChorusFilterTween> TweensDepth(this IEnumerable<AudioChorusFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DepthAudioChorusFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDepth(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DryMixAudioChorusFilterTween TweenDryMix(this AudioChorusFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DryMixAudioChorusFilterTween, AudioChorusFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DryMixAudioChorusFilterTween> TweensDryMix(this IEnumerable<AudioChorusFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DryMixAudioChorusFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDryMix(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RateAudioChorusFilterTween TweenRate(this AudioChorusFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RateAudioChorusFilterTween, AudioChorusFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<RateAudioChorusFilterTween> TweensRate(this IEnumerable<AudioChorusFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RateAudioChorusFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRate(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WetMix1AudioChorusFilterTween TweenWetMix1(this AudioChorusFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMix1AudioChorusFilterTween, AudioChorusFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<WetMix1AudioChorusFilterTween> TweensWetMix1(this IEnumerable<AudioChorusFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WetMix1AudioChorusFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWetMix1(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WetMix2AudioChorusFilterTween TweenWetMix2(this AudioChorusFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMix2AudioChorusFilterTween, AudioChorusFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<WetMix2AudioChorusFilterTween> TweensWetMix2(this IEnumerable<AudioChorusFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WetMix2AudioChorusFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWetMix2(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WetMix3AudioChorusFilterTween TweenWetMix3(this AudioChorusFilter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMix3AudioChorusFilterTween, AudioChorusFilter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<WetMix3AudioChorusFilterTween> TweensWetMix3(this IEnumerable<AudioChorusFilter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WetMix3AudioChorusFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWetMix3(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}