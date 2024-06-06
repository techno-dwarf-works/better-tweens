using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class AudioDistortionFilterExtensions
    {
        public static LevelAudioDistortionFilterTween TweenLevel(this AudioDistortionFilter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LevelAudioDistortionFilterTween, AudioDistortionFilter, float>(options, optionsMode);
        }
    }
}