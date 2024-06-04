using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PropertyIntMaterialTween : IntTween<Material>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;

        public PropertyIntMaterialTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override int GetCurrentValue()
        {
            return Target.GetInteger(PropertyName);
        }

        protected override void SetCurrentValue(int value)
        {
            Target.SetInteger(PropertyName, value);
        }
    }
}