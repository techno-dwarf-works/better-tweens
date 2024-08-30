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
    }
}