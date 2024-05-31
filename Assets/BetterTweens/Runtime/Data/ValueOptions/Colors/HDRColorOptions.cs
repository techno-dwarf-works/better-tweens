using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Triggers.ValueOptions
{
    [Serializable]
    public class HDRColorOptions : ColorOptions
    {
        [ColorUsage(showAlpha: true, hdr: true)]
        [SerializeField] private Color _value;

        public override Color Color => _value;
    }
}