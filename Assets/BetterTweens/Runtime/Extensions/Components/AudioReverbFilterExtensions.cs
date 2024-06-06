using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioReverbFilterExtensions
    {
        public static DecayHFRatioAudioReverbFilterTween TweenDecayHFRatio(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayHFRatioAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DecayHFRatioAudioReverbFilterTween> TweensDecayHFRatio(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DecayHFRatioAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDecayHFRatio(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DecayTimeAudioReverbFilterTween TweenDecayTime(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayTimeAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DecayTimeAudioReverbFilterTween> TweensDecayTime(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DecayTimeAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDecayTime(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DensityAudioReverbFilterTween TweenDensity(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DensityAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DensityAudioReverbFilterTween> TweensDensity(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DensityAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDensity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DiffusionAudioReverbFilterTween TweenDiffusion(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DiffusionAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DiffusionAudioReverbFilterTween> TweensDiffusion(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DiffusionAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDiffusion(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DryLevelAudioReverbFilterTween TweenDryLevel(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DryLevelAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<DryLevelAudioReverbFilterTween> TweensDryLevel(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DryLevelAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDryLevel(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static HfReferenceAudioReverbFilterTween TweenHfReference(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<HfReferenceAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<HfReferenceAudioReverbFilterTween> TweensHfReference(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<HfReferenceAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenHfReference(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LfReferenceAudioReverbFilterTween TweenLFReference(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LfReferenceAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<LfReferenceAudioReverbFilterTween> TweensLFReference(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<LfReferenceAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLFReference(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReflectionsLevelAudioReverbFilterTween TweenReflectionsLevel(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsLevelAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<ReflectionsLevelAudioReverbFilterTween> TweensReflectionsLevel(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ReflectionsLevelAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReflectionsLevel(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReflectionsDelayAudioReverbFilterTween TweenReflectionsDelay(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsDelayAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<ReflectionsDelayAudioReverbFilterTween> TweensReflectionsDelay(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ReflectionsDelayAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReflectionsDelay(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReverbLevelAudioReverbFilterTween TweenReverbLevel(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbLevelAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<ReverbLevelAudioReverbFilterTween> TweensReverbLevel(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ReverbLevelAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReverbLevel(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReverbDelayAudioReverbFilterTween TweenReverbDelay(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbDelayAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<ReverbDelayAudioReverbFilterTween> TweensReverbDelay(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ReverbDelayAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReverbDelay(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RoomAudioReverbFilterTween TweenRoom(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<RoomAudioReverbFilterTween> TweensRoom(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RoomAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRoom(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RoomHFAudioReverbFilterTween TweenRoomHF(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomHFAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<RoomHFAudioReverbFilterTween> TweensRoomHF(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RoomHFAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRoomHF(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RoomLFAudioReverbFilterTween TweenRoomLF(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomLFAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static IEnumerable<RoomLFAudioReverbFilterTween> TweensRoomLF(this IEnumerable<AudioReverbFilter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RoomLFAudioReverbFilterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRoomLF(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}