using System;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime
{
    public class FuncEase : Ease
    {
        private readonly Func<float, float> _func;

        public FuncEase(Func<float, float> func)
        {
            if (func == null)
            {
                var message = $"{nameof(func)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            _func = func;
        }

        public override float Evaluate(float time)
        {
            if (_func == null)
            {
                return time;
            }

            return _func.Invoke(time);
        }

        public override Ease Clone()
        {
            return new FuncEase(_func);
        }
    }
}