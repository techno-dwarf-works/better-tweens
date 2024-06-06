using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioHighPassFilterExtensions
    {
        public static ResonanceAudioHighPassFilterTween TweenResonance(this AudioHighPassFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ResonanceAudioHighPassFilterTween, AudioHighPassFilter, float>(options, optionsMode);
        }

        public static FrequencyAudioHighPassFilterTween TweenFrequency(this AudioHighPassFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrequencyAudioHighPassFilterTween, AudioHighPassFilter, float>(options, optionsMode);
        }
    }
}