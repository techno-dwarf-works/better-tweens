using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Triggers.ValueOptions
{
    [Serializable]
    public class LDRColorOptions : ColorOptions
    {
        [ColorUsage(showAlpha: true, hdr: false)]
        [SerializeField] private Color _value;

        public override Color Color => _value;
    }
}