using System;
using Better.Commons.Runtime.Interfaces;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public abstract class TweenCoreAction : ICloneable<TweenCoreAction>
    {
        private SettingsData Settings => TweensSettings.Instance.Current;

        public bool TryInvoke(TweenCore tweenCore)
        {
            if (tweenCore == null)
            {
                return false;
            }

            if (ReadinessFor(tweenCore))
            {
                if (Settings.SafeMode)
                {
                    return SafeInvoke(tweenCore);
                }

                Invoke(tweenCore);
                return true;
            }

            return false;
        }

        protected abstract void Invoke(TweenCore tweenCore);

        protected bool SafeInvoke(TweenCore tweenCore, bool logException = true)
        {
            try
            {
                Invoke(tweenCore);
                return true;
            }
            catch (Exception exception)
            {
                if (logException)
                {
                    LogUtility.LogException(exception);
                }

                return false;
            }
        }

        protected abstract bool ReadinessFor(TweenCore tweenCore);

        public abstract TweenCoreAction Clone();
    }
}