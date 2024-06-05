using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class GravityPhysics2DTween : Vector2Tween
    {
        protected override Vector2 GetCurrentValue()
        {
            return Physics2D.gravity;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Physics2D.gravity = value;
        }
    }
}