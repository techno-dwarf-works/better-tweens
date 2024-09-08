using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FloatPropertyBlockRendererTween : FloatTween<Renderer>
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

        public FloatPropertyBlockRendererTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override float GetCurrentValue()
        {
            Target.GetPropertyBlock(PropertyBlock);
            return PropertyBlock.GetFloat(PropertyName);
        }

        protected override void SetCurrentValue(float value)
        {
            PropertyBlock.SetFloat(PropertyName, value);
            Target.SetPropertyBlock(PropertyBlock);
        }
        
        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is FloatPropertyBlockRendererTween propertySource)
            {
                _propertyName = propertySource._propertyName;
            }

            return base.As(source);
        }
    }
}