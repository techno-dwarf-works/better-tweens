using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PropertyVectorMaterialTween : Vector4Tween<Material>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;

        public PropertyVectorMaterialTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override Vector4 GetCurrentValue()
        {
            return Target.GetVector(PropertyName);
        }

        protected override void SetCurrentValue(Vector4 value)
        {
            Target.SetVector(PropertyName, value);
        }
        
        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is PropertyVectorMaterialTween propertySource)
            {
                _propertyName = propertySource._propertyName;
            }

            return base.As(source);
        }
    }
}