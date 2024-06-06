using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioReverbZoneExtensions
    {
        public static DecayHFRatioAudioReverbZoneTween TweenDecayHFRatio(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayHFRatioAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static DecayTimeAudioReverbZoneTween TweenDecayTime(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayTimeAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static DensityAudioReverbZoneTween TweenDensity(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DensityAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static DiffusionAudioReverbZoneTween TweenDiffusion(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DiffusionAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static HFReferenceAudioReverbZoneTween TweenHFReference(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<HFReferenceAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static LFReferenceAudioReverbZoneTween TweenLFReference(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LFReferenceAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static MaxDistanceAudioReverbZoneTween TweenMaxDistance(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDistanceAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static MinDistanceAudioReverbZoneTween TweenMinDistance(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinDistanceAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static ReflectionsAudioReverbZoneTween TweenReflections(this AudioReverbZone self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsAudioReverbZoneTween, AudioReverbZone, int>(options, optionsMode);
        }

        public static ReflectionsDelayAudioReverbZoneTween TweenReflectionsDelay(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsDelayAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static ReverbAudioReverbZoneTween TweenReverb(this AudioReverbZone self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbAudioReverbZoneTween, AudioReverbZone, int>(options, optionsMode);
        }

        public static ReverbDelayAudioReverbZoneTween TweenReverbDelay(this AudioReverbZone self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbDelayAudioReverbZoneTween, AudioReverbZone, float>(options, optionsMode);
        }

        public static RoomAudioReverbZoneTween TweenRoom(this AudioReverbZone self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomAudioReverbZoneTween, AudioReverbZone, int>(options, optionsMode);
        }

        public static RoomHFAudioReverbZoneTween TweenRoomHF(this AudioReverbZone self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomHFAudioReverbZoneTween, AudioReverbZone, int>(options, optionsMode);
        }

        public static RoomLFAudioReverbZoneTween TweenRoomLF(this AudioReverbZone self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomLFAudioReverbZoneTween, AudioReverbZone, int>(options, optionsMode);
        }
    }
}