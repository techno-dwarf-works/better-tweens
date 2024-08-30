using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioSourceExtensions
    {
        public static BypassEffectsAudioSourceTween TweenBypassEffects(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassEffectsAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<BypassEffectsAudioSourceTween> TweensBypassEffects(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BypassEffectsAudioSourceTween>();
            }

            var tweens = new List<BypassEffectsAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBypassEffects(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BypassListenerAudioSourceTween TweenBypassListener(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassListenerAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<BypassListenerAudioSourceTween> TweensBypassListener(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BypassListenerAudioSourceTween>();
            }

            var tweens = new List<BypassListenerAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBypassListener(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BypassReverbZonesAudioSourceTween TweenBypassReverbZones(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassReverbZonesAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<BypassReverbZonesAudioSourceTween> TweensBypassReverbZones(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BypassReverbZonesAudioSourceTween>();
            }

            var tweens = new List<BypassReverbZonesAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBypassReverbZones(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DopplerLevelAudioSourceTween TweenDopplerLevel(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DopplerLevelAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DopplerLevelAudioSourceTween> TweensDopplerLevel(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<DopplerLevelAudioSourceTween>();
            }

            var tweens = new List<DopplerLevelAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDopplerLevel(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IgnoreListenerPauseAudioSourceTween TweenIgnoreListenerPause(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreListenerPauseAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<IgnoreListenerPauseAudioSourceTween> TweensIgnoreListenerPause(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<IgnoreListenerPauseAudioSourceTween>();
            }

            var tweens = new List<IgnoreListenerPauseAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIgnoreListenerPause(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IgnoreListenerVolumeAudioSourceTween TweenIgnoreListenerVolume(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreListenerVolumeAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<IgnoreListenerVolumeAudioSourceTween> TweensIgnoreListenerVolume(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<IgnoreListenerVolumeAudioSourceTween>();
            }

            var tweens = new List<IgnoreListenerVolumeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIgnoreListenerVolume(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LoopAudioSourceTween TweenLoop(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<LoopAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<LoopAudioSourceTween> TweensLoop(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LoopAudioSourceTween>();
            }

            var tweens = new List<LoopAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLoop(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaxDistanceAudioSourceTween TweenMaxDistance(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDistanceAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MaxDistanceAudioSourceTween> TweensMaxDistance(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<MaxDistanceAudioSourceTween>();
            }

            var tweens = new List<MaxDistanceAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaxDistance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MinDistanceAudioSourceTween TweenMinDistance(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinDistanceAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MinDistanceAudioSourceTween> TweensMinDistance(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<MinDistanceAudioSourceTween>();
            }

            var tweens = new List<MinDistanceAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMinDistance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MuteAudioSourceTween TweenMute(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MuteAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<MuteAudioSourceTween> TweensMute(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<MuteAudioSourceTween>();
            }

            var tweens = new List<MuteAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMute(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PanStereoAudioSourceTween TweenPanStereo(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PanStereoAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<PanStereoAudioSourceTween> TweensPanStereo(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PanStereoAudioSourceTween>();
            }

            var tweens = new List<PanStereoAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPanStereo(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PitchAudioSourceTween TweenPitch(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PitchAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<PitchAudioSourceTween> TweensPitch(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PitchAudioSourceTween>();
            }

            var tweens = new List<PitchAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPitch(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PlayAudioSourceTween TweenPlay(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<PlayAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<PlayAudioSourceTween> TweensPlay(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PlayAudioSourceTween>();
            }

            var tweens = new List<PlayAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPlay(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PriorityAudioSourceTween TweenPriority(this AudioSource self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PriorityAudioSourceTween, AudioSource, int>(duration, options, optionsMode);
        }

        public static IEnumerable<PriorityAudioSourceTween> TweensPriority(this IEnumerable<AudioSource> self, float duration, int options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PriorityAudioSourceTween>();
            }

            var tweens = new List<PriorityAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPriority(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReverbZoneMixAudioSourceTween TweenReverbZoneMix(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbZoneMixAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ReverbZoneMixAudioSourceTween> TweensReverbZoneMix(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ReverbZoneMixAudioSourceTween>();
            }

            var tweens = new List<ReverbZoneMixAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReverbZoneMix(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpatialBlendAudioSourceTween TweenSpatialBlend(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatialBlendAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<SpatialBlendAudioSourceTween> TweensSpatialBlend(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<SpatialBlendAudioSourceTween>();
            }

            var tweens = new List<SpatialBlendAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpatialBlend(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpatializeAudioSourceTween TweenSpatialize(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatializeAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<SpatializeAudioSourceTween> TweensSpatialize(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<SpatializeAudioSourceTween>();
            }

            var tweens = new List<SpatializeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpatialize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpatializePostEffectsAudioSourceTween TweenSpatializePostEffects(this AudioSource self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatializePostEffectsAudioSourceTween, AudioSource, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<SpatializePostEffectsAudioSourceTween> TweensSpatializePostEffects(this IEnumerable<AudioSource> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<SpatializePostEffectsAudioSourceTween>();
            }

            var tweens = new List<SpatializePostEffectsAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpatializePostEffects(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpreadAudioSourceTween TweenSpread(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpreadAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<SpreadAudioSourceTween> TweensSpread(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<SpreadAudioSourceTween>();
            }

            var tweens = new List<SpreadAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpread(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TimeAudioSourceTween TweenTime(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<TimeAudioSourceTween> TweensTime(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<TimeAudioSourceTween>();
            }

            var tweens = new List<TimeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTime(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TimeSamplesAudioSourceTween TweenTimeSamples(this AudioSource self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeSamplesAudioSourceTween, AudioSource, int>(duration, options, optionsMode);
        }

        public static IEnumerable<TimeSamplesAudioSourceTween> TweensTimeSamples(this IEnumerable<AudioSource> self, float duration, int options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<TimeSamplesAudioSourceTween>();
            }

            var tweens = new List<TimeSamplesAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTimeSamples(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VolumeAudioSourceTween TweenVolume(this AudioSource self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<VolumeAudioSourceTween, AudioSource, float>(duration, options, optionsMode);
        }

        public static IEnumerable<VolumeAudioSourceTween> TweensVolume(this IEnumerable<AudioSource> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<VolumeAudioSourceTween>();
            }

            var tweens = new List<VolumeAudioSourceTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVolume(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}