using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PlayAudioSourceTween : BoolTween<AudioSource>
    {
        [SerializeField] private bool _once;
        private bool _isPlaying;
        public bool Once => _once;

        public PlayAudioSourceTween SetOnce(bool once = true)
        {
            _once = once;
            return this;
        }

        protected override bool GetCurrentValue()
        {
            return Target.isPlaying;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.isPlaying == value)
            {
                return;
            }

            if (value && _once && _isPlaying)
            {
                return;
            }

            _isPlaying = value;
            if (value) Target.Play();
            else Target.Pause();
        }
    }
}