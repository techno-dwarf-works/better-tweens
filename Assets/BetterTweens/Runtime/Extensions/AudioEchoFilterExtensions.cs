using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioEchoFilterExtensions
    {
        public static DecayRatioAudioEchoFilterTween TweenDecayRatio(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DecayRatioAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }

        public static DelayAudioEchoFilterTween TweenDelay(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DelayAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }

        public static DryMixAudioEchoFilterTween TweenDryMix(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DryMixAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }

        public static WetMixAudioEchoFilterTween TweenWetMix(this AudioEchoFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WetMixAudioEchoFilterTween, AudioEchoFilter, float>(options, optionsMode);
        }
    }
}