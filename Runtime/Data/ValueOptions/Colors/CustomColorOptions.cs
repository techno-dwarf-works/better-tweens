using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    public class CustomColorOptions : ColorOptions
    {
        private Color _value;
        public override Color Color => _value;

        public CustomColorOptions(Color value)
        {
            _value = value;
        }
    }
}