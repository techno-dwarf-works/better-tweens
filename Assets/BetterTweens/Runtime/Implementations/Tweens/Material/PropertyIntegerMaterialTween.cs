﻿using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PropertyIntegerMaterialTween : IntTween<Material>
    {
        [SerializeField] private string _propertyName;
        public string PropertyName => _propertyName;

        public PropertyIntegerMaterialTween SetPropertyName(string name)
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
        
        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is PropertyIntegerMaterialTween propertySource)
            {
                _propertyName = propertySource._propertyName;
            }

            return base.As(source);
        }
    }
}