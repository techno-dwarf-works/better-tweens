using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PropertyColorMaterialTween : ColorTween<Material>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;

        public PropertyColorMaterialTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override Color GetCurrentValue()
        {
            return Target.GetColor(PropertyName);
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.SetColor(PropertyName, value);
        }
    }
}