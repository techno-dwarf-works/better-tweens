using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PropertyTextureScaleMaterialTween : Vector2Tween<Material>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;

        public PropertyTextureScaleMaterialTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override Vector2 GetCurrentValue()
        {
            return Target.GetTextureScale(PropertyName);
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.SetTextureScale(PropertyName, value);
        }
    }
}