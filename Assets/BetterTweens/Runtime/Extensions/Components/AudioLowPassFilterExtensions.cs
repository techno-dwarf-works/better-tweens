using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioLowPassFilterExtensions
    {
        public static ResonanceAudioLowPassFilterTween TweenResonance(this AudioLowPassFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ResonanceAudioLowPassFilterTween, AudioLowPassFilter, float>(options, optionsMode);
        }

        public static FrequencyAudioLowPassFilterTween TweenFrequency(this AudioLowPassFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrequencyAudioLowPassFilterTween, AudioLowPassFilter, float>(options, optionsMode);
        }
    }
}