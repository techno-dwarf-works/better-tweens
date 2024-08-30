using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class HDRColorOptions : ColorOptions
    {
        [ColorUsage(showAlpha: true, hdr: true)]
        [SerializeField] private Color _value;

        public override Color Color => _value;

        public HDRColorOptions(Color value)
        {
            _value = value;
        }

        public HDRColorOptions() : this(Color.white)
        {
        }
    }
}