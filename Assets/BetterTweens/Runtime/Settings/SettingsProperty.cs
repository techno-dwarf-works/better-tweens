using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Settings
{
    [Serializable]
    public class SettingsProperty<T>
    {
        [SerializeField] private T _editorValue;
        private T _runtimeValue;

        private bool IsRuntime => Application.isPlaying;

        public T Value
        {
            get => IsRuntime ? _runtimeValue : _editorValue;
            set
            {
                if (IsRuntime) _runtimeValue = value;
                else _editorValue = value;
            }
        }

        public SettingsProperty(T value)
        {
            _editorValue = value;
        }

        public SettingsProperty() : this(default)
        {
        }

        public void ResetValue()
        {
            _runtimeValue = _editorValue;
        }
    }
}