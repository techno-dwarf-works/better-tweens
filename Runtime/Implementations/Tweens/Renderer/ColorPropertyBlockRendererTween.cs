using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ColorPropertyBlockRendererTween : ColorTween<Renderer>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;
        protected MaterialPropertyBlock PropertyBlock { get; private set; }

        protected internal override void OnStarted()
        {
            PropertyBlock = new();
            Target.GetPropertyBlock(PropertyBlock);

            base.OnStarted();
        }

        public ColorPropertyBlockRendererTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override Color GetCurrentValue()
        {
            Target.GetPropertyBlock(PropertyBlock);
            return PropertyBlock.GetColor(PropertyName);
        }

        protected override void SetCurrentValue(Color value)
        {
            PropertyBlock.SetColor(PropertyName, value);
            Target.SetPropertyBlock(PropertyBlock);
        }
    }
}