using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioReverbZoneExtensions
    {
        public static DecayHFRatioAudioReverbZoneTween TweenDecayHFRatio(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayHFRatioAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DecayHFRatioAudioReverbZoneTween> TweensDecayHFRatio(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<DecayHFRatioAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDecayHFRatio(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DecayTimeAudioReverbZoneTween TweenDecayTime(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayTimeAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DecayTimeAudioReverbZoneTween> TweensDecayTime(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<DecayTimeAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDecayTime(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DensityAudioReverbZoneTween TweenDensity(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DensityAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DensityAudioReverbZoneTween> TweensDensity(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<DensityAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDensity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DiffusionAudioReverbZoneTween TweenDiffusion(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DiffusionAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DiffusionAudioReverbZoneTween> TweensDiffusion(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<DiffusionAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDiffusion(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static HFReferenceAudioReverbZoneTween TweenHFReference(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<HFReferenceAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<HFReferenceAudioReverbZoneTween> TweensHFReference(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<HFReferenceAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenHFReference(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LFReferenceAudioReverbZoneTween TweenLFReference(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LFReferenceAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<LFReferenceAudioReverbZoneTween> TweensLFReference(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<LFReferenceAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLFReference(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaxDistanceAudioReverbZoneTween TweenMaxDistance(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDistanceAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MaxDistanceAudioReverbZoneTween> TweensMaxDistance(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MaxDistanceAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaxDistance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MinDistanceAudioReverbZoneTween TweenMinDistance(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinDistanceAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MinDistanceAudioReverbZoneTween> TweensMinDistance(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MinDistanceAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMinDistance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReflectionsAudioReverbZoneTween TweenReflections(this AudioReverbZone self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsAudioReverbZoneTween, AudioReverbZone, int>(duration, options, optionsMode);
        }

        public static IEnumerable<ReflectionsAudioReverbZoneTween> TweensReflections(this IEnumerable<AudioReverbZone> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<ReflectionsAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReflections(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReflectionsDelayAudioReverbZoneTween TweenReflectionsDelay(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsDelayAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ReflectionsDelayAudioReverbZoneTween> TweensReflectionsDelay(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<ReflectionsDelayAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReflectionsDelay(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReverbAudioReverbZoneTween TweenReverb(this AudioReverbZone self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbAudioReverbZoneTween, AudioReverbZone, int>(duration, options, optionsMode);
        }

        public static IEnumerable<ReverbAudioReverbZoneTween> TweensReverb(this IEnumerable<AudioReverbZone> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<ReverbAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReverb(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReverbDelayAudioReverbZoneTween TweenReverbDelay(this AudioReverbZone self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbDelayAudioReverbZoneTween, AudioReverbZone, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ReverbDelayAudioReverbZoneTween> TweensReverbDelay(this IEnumerable<AudioReverbZone> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<ReverbDelayAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReverbDelay(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RoomAudioReverbZoneTween TweenRoom(this AudioReverbZone self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomAudioReverbZoneTween, AudioReverbZone, int>(duration, options, optionsMode);
        }

        public static IEnumerable<RoomAudioReverbZoneTween> TweensRoom(this IEnumerable<AudioReverbZone> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<RoomAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRoom(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RoomHFAudioReverbZoneTween TweenRoomHF(this AudioReverbZone self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomHFAudioReverbZoneTween, AudioReverbZone, int>(duration, options, optionsMode);
        }

        public static IEnumerable<RoomHFAudioReverbZoneTween> TweensRoomHF(this IEnumerable<AudioReverbZone> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<RoomHFAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRoomHF(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RoomLFAudioReverbZoneTween TweenRoomLF(this AudioReverbZone self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomLFAudioReverbZoneTween, AudioReverbZone, int>(duration, options, optionsMode);
        }

        public static IEnumerable<RoomLFAudioReverbZoneTween> TweensRoomLF(this IEnumerable<AudioReverbZone> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<RoomLFAudioReverbZoneTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRoomLF(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}