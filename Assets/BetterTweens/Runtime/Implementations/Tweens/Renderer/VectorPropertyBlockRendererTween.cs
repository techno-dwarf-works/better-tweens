using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class VectorPropertyBlockRendererTween : Vector4Tween<Renderer>
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

        public VectorPropertyBlockRendererTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override Vector4 GetCurrentValue()
        {
            Target.GetPropertyBlock(PropertyBlock);
            return PropertyBlock.GetVector(PropertyName);
        }

        protected override void SetCurrentValue(Vector4 value)
        {
            PropertyBlock.SetVector(PropertyName, value);
            Target.SetPropertyBlock(PropertyBlock);
        }
    }
}