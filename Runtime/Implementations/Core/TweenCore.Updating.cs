using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        internal void OnUpdate(float deltaTime)
        {
            if (InvokeTriggers())
            {
                return;
            }

            if (TryHandleBroken() && IsBroken())
            {
                return;
            }

            ApplyTimeScale(ref deltaTime);
            OnPreUpdated(deltaTime);
            OnPostUpdated(deltaTime);
        }

        protected virtual void OnPreUpdated(float deltaTime)
        {
            _activityMachine.CurrentState?.OnUpdate(deltaTime);
        }

        protected virtual void OnPostUpdated(float deltaTime)
        {
            ActionUtility.TryInvokeBySafeMode(Updated);
        }

        protected bool InvokeTriggers()
        {
            if (_triggers == null)
            {
                return false;
            }

            foreach (var trigger in _triggers)
            {
                if (trigger.Invoke(this))
                {
                    return true;
                }
            }

            return false;
        }

        private void ApplyTimeScale(ref float value)
        {
            value *= LocalTimeScale;
            if (DependGlobalTimeScale)
            {
                value *= SettingsData.GlobalTimeScale;
            }
        }
    }
}