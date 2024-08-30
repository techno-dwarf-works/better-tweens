using System;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public class FuncEase : Ease
    {
        private readonly Func<float, float> _func;

        public FuncEase(Func<float, float> func)
        {
            if (!ValidationUtility.Validate(func))
            {
                return;
            }

            _func = func;
        }

        public override float Evaluate(float time)
        {
            if (FuncUtility.TryInvokeBySafeMode(_func, time, out var result))
            {
                return result;
            }

            return time;
        }

        public override Ease Clone()
        {
            return new FuncEase(_func);
        }
    }
}