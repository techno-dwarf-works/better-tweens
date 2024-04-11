using System;

namespace Better.Tweens.Runtime
{
    [Flags]
    public enum EaseMode
    {
        In = 1,
        Out = 2,
        InOut = In | Out,
    }
}