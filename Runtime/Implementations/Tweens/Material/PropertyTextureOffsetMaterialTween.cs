using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PropertyTextureOffsetMaterialTween : Vector2Tween<Material>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;

        public PropertyTextureOffsetMaterialTween SetPropertyName(string name)
        {
            _propertyName = name;
            return this;
        }

        protected override Vector2 GetCurrentValue()
        {
            return Target.GetTextureOffset(PropertyName);
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.SetTextureOffset(PropertyName, value);
        }
        
        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is PropertyTextureOffsetMaterialTween propertySource)
            {
                _propertyName = propertySource._propertyName;
            }

            return base.As(source);
        }
    }
}