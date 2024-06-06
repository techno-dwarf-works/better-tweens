using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioSourceExtensions
    {
        public static BypassEffectsAudioSourceTween TweenBypassEffects(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassEffectsAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static BypassListenerAudioSourceTween TweenBypassListener(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassListenerAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static BypassReverbZonesAudioSourceTween TweenBypassReverbZones(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BypassReverbZonesAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static DopplerLevelAudioSourceTween TweenDopplerLevel(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DopplerLevelAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static IgnoreListenerPauseAudioSourceTween TweenIgnoreListenerPause(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreListenerPauseAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static IgnoreListenerVolumeAudioSourceTween TweenIgnoreListenerVolume(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreListenerVolumeAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static LoopAudioSourceTween TweenLoop(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<LoopAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static MaxDistanceAudioSourceTween TweenMaxDistance(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDistanceAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static MinDistanceAudioSourceTween TweenMinDistance(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinDistanceAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static MuteAudioSourceTween TweenMute(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MuteAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static PanStereoAudioSourceTween TweenPanStereo(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PanStereoAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static PitchAudioSourceTween TweenPitch(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PitchAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static PlayAudioSourceTween TweenPlay(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<PlayAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static PriorityAudioSourceTween TweenPriority(this AudioSource self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PriorityAudioSourceTween, AudioSource, int>(options, optionsMode);
        }

        public static ReverbZoneMixAudioSourceTween TweenReverbZoneMix(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbZoneMixAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static SpatialBlendAudioSourceTween TweenSpatialBlend(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatialBlendAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static SpatializeAudioSourceTween TweenSpatialize(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatializeAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static SpatializePostEffectsAudioSourceTween TweenSpatializePostEffects(this AudioSource self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpatializePostEffectsAudioSourceTween, AudioSource, bool>(options, optionsMode);
        }

        public static SpreadAudioSourceTween TweenSpread(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpreadAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static TimeAudioSourceTween TweenTime(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeAudioSourceTween, AudioSource, float>(options, optionsMode);
        }

        public static TimeSamplesAudioSourceTween TweenTimeSamples(this AudioSource self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeSamplesAudioSourceTween, AudioSource, int>(options, optionsMode);
        }

        public static VolumeAudioSourceTween TweenVolume(this AudioSource self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<VolumeAudioSourceTween, AudioSource, float>(options, optionsMode);
        }
    }
}