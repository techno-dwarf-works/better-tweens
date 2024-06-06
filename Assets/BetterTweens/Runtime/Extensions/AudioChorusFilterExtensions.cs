using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioChorusFilterExtensions
    {
        public static DelayAudioChorusFilterTween TweenDelay(this AudioChorusFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DelayAudioChorusFilterTween, AudioChorusFilter, float>(options, optionsMode);
        }

        public static DepthAudioChorusFilterTween TweenDepth(this AudioChorusFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DepthAudioChorusFilterTween, AudioChorusFilter, float>(options, optionsMode);
        }

        public static DryMixAudioChorusFilterTween TweenDryMix(this AudioChorusFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DryMixAudioChorusFilterTween, AudioChorusFilter, float>(options, optionsMode);
        }

        public static RateAudioChorusFilterTween TweenRate(this AudioChorusFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RateAudioChorusFilterTween, AudioChorusFilter, float>(options, optionsMode);
        }

        public static WetMix1AudioChorusFilterTween TweenWetMix1(this AudioChorusFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMix1AudioChorusFilterTween, AudioChorusFilter, float>(options, optionsMode);
        }

        public static WetMix2AudioChorusFilterTween TweenWetMix2(this AudioChorusFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMix2AudioChorusFilterTween, AudioChorusFilter, float>(options, optionsMode);
        }

        public static WetMix3AudioChorusFilterTween TweenWetMix3(this AudioChorusFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMix3AudioChorusFilterTween, AudioChorusFilter, float>(options, optionsMode);
        }
    }
}