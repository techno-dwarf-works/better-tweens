using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Properties
{
    [Serializable]
    public class TweenProperties<TValue> : CoreProperties
    {
        [SerializeField] private OptionsMode _optionsMode;
        [SerializeField] private FromMode _fromMode;
        [SerializeField] private TValue _fromValue;

        public OptionsMode OptionsMode
        {
            get => _optionsMode;
            internal set => _optionsMode = value;
        }

        internal FromMode FromMode
        {
            get => _fromMode;
            set => _fromMode = value;
        }

        internal TValue FromValue
        {
            get => _fromValue;
            set => _fromValue = value;
        }
    }
}