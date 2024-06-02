using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ActiveGameObjectTween : BoolTween<GameObject>
    {
        protected override bool GetCurrentValue()
        {
            return Target.activeSelf;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.activeSelf == value)
            {
                return;
            }

            Target.SetActive(value);
        }
    }
}