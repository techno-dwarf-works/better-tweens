﻿using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public class TogglePauseAction : SingleAction<TogglePauseAction>
    {
        public override void Invoke(TweenCore tweenCore)
        {
            tweenCore.TogglePause();
        }

        public override bool ReadinessFor(TweenCore tweenCore)
        {
            return tweenCore.IsPausable() || tweenCore.IsPlayable();
        }
    }
}