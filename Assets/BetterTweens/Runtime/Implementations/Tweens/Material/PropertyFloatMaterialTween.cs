using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PropertyFloatMaterialTween : FloatTween<Material>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;

        public PropertyFloatMaterialTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override float GetCurrentValue()
        {
            return Target.GetFloat(PropertyName);
        }

        protected override void SetCurrentValue(float value)
        {
            Target.SetFloat(PropertyName, value);
        }
        
        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is PropertyFloatMaterialTween propertySource)
            {
                _propertyName = propertySource._propertyName;
            }

            return base.As(source);
        }
    }
}