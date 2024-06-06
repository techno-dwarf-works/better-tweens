using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioSourceExtensions
    {
        public static BypassEffectsAudioSourceTween TweenBypassEffects(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassEffectsAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<BypassEffectsAudioSourceTween> TweensBypassEffects(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BypassEffectsAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBypassEffects(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BypassListenerAudioSourceTween TweenBypassListener(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassListenerAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<BypassListenerAudioSourceTween> TweensBypassListener(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BypassListenerAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBypassListener(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BypassReverbZonesAudioSourceTween TweenBypassReverbZones(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassReverbZonesAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<BypassReverbZonesAudioSourceTween> TweensBypassReverbZones(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BypassReverbZonesAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBypassReverbZones(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DopplerLevelAudioSourceTween TweenDopplerLevel(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DopplerLevelAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<DopplerLevelAudioSourceTween> TweensDopplerLevel(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DopplerLevelAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDopplerLevel(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IgnoreListenerPauseAudioSourceTween TweenIgnoreListenerPause(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreListenerPauseAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<IgnoreListenerPauseAudioSourceTween> TweensIgnoreListenerPause(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<IgnoreListenerPauseAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIgnoreListenerPause(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IgnoreListenerVolumeAudioSourceTween TweenIgnoreListenerVolume(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreListenerVolumeAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<IgnoreListenerVolumeAudioSourceTween> TweensIgnoreListenerVolume(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<IgnoreListenerVolumeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIgnoreListenerVolume(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LoopAudioSourceTween TweenLoop(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<LoopAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<LoopAudioSourceTween> TweensLoop(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<LoopAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLoop(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaxDistanceAudioSourceTween TweenMaxDistance(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDistanceAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<MaxDistanceAudioSourceTween> TweensMaxDistance(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MaxDistanceAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaxDistance(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MinDistanceAudioSourceTween TweenMinDistance(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinDistanceAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<MinDistanceAudioSourceTween> TweensMinDistance(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MinDistanceAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMinDistance(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MuteAudioSourceTween TweenMute(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MuteAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<MuteAudioSourceTween> TweensMute(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MuteAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMute(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PanStereoAudioSourceTween TweenPanStereo(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PanStereoAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<PanStereoAudioSourceTween> TweensPanStereo(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PanStereoAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPanStereo(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PitchAudioSourceTween TweenPitch(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PitchAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<PitchAudioSourceTween> TweensPitch(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PitchAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPitch(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PlayAudioSourceTween TweenPlay(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<PlayAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<PlayAudioSourceTween> TweensPlay(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PlayAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPlay(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PriorityAudioSourceTween TweenPriority(this AudioSource self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PriorityAudioSourceTween, AudioSource, int>(options, optionsMode);
        }

        public static IEnumerable<PriorityAudioSourceTween> TweensPriority(this IEnumerable<AudioSource> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PriorityAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPriority(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReverbZoneMixAudioSourceTween TweenReverbZoneMix(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbZoneMixAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<ReverbZoneMixAudioSourceTween> TweensReverbZoneMix(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ReverbZoneMixAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReverbZoneMix(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpatialBlendAudioSourceTween TweenSpatialBlend(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatialBlendAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<SpatialBlendAudioSourceTween> TweensSpatialBlend(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SpatialBlendAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpatialBlend(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpatializeAudioSourceTween TweenSpatialize(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatializeAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<SpatializeAudioSourceTween> TweensSpatialize(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SpatializeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpatialize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpatializePostEffectsAudioSourceTween TweenSpatializePostEffects(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatializePostEffectsAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IEnumerable<SpatializePostEffectsAudioSourceTween> TweensSpatializePostEffects(this IEnumerable<AudioSource> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SpatializePostEffectsAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpatializePostEffects(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpreadAudioSourceTween TweenSpread(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpreadAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<SpreadAudioSourceTween> TweensSpread(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SpreadAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpread(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TimeAudioSourceTween TweenTime(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<TimeAudioSourceTween> TweensTime(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<TimeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTime(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TimeSamplesAudioSourceTween TweenTimeSamples(this AudioSource self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeSamplesAudioSourceTween, AudioSource, int>(options, optionsMode);
        }

        public static IEnumerable<TimeSamplesAudioSourceTween> TweensTimeSamples(this IEnumerable<AudioSource> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<TimeSamplesAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTimeSamples(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VolumeAudioSourceTween TweenVolume(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<VolumeAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IEnumerable<VolumeAudioSourceTween> TweensVolume(this IEnumerable<AudioSource> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<VolumeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVolume(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}