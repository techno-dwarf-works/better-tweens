using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class IntegerPropertyBlockRendererTween : IntTween<Renderer>
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

        public IntegerPropertyBlockRendererTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override int GetCurrentValue()
        {
            Target.GetPropertyBlock(PropertyBlock);
            return PropertyBlock.GetInteger(PropertyName);
        }

        protected override void SetCurrentValue(int value)
        {
            PropertyBlock.SetInteger(PropertyName, value);
            Target.SetPropertyBlock(PropertyBlock);
        }
    }
}