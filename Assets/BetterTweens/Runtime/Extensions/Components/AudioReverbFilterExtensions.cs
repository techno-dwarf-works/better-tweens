using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioReverbFilterExtensions
    {
        public static DecayHFRatioAudioReverbFilterTween TweenDecayHFRatio(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayHFRatioAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static DecayTimeAudioReverbFilterTween TweenDecayTime(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayTimeAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static DensityAudioReverbFilterTween TweenDensity(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DensityAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static DiffusionAudioReverbFilterTween TweenDiffusion(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DiffusionAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }
        
        public static DryLevelAudioReverbFilterTween TweenDryLevel(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DryLevelAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static HfReferenceAudioReverbFilterTween TweenHfReference(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<HfReferenceAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static LfReferenceAudioReverbFilterTween TweenLFReference(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LfReferenceAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static ReflectionsLevelAudioReverbFilterTween TweenReflectionsLevel(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsLevelAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static ReflectionsDelayAudioReverbFilterTween TweenReflectionsDelay(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReflectionsDelayAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static ReverbLevelAudioReverbFilterTween TweenReverbLevel(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbLevelAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static ReverbDelayAudioReverbFilterTween TweenReverbDelay(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReverbDelayAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static RoomAudioReverbFilterTween TweenRoom(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static RoomHFAudioReverbFilterTween TweenRoomHF(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomHFAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }

        public static RoomLFAudioReverbFilterTween TweenRoomLF(this AudioReverbFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RoomLFAudioReverbFilterTween, AudioReverbFilter, float>(options, optionsMode);
        }
    }
}