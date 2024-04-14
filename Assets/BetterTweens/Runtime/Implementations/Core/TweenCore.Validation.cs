using System.Collections.Generic;
using System.Linq;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public bool IsActive()
        {
            return Initialized && _stateMachine.InState<ActiveState>();
        }

        public bool IsPlaying()
        {
            return Initialized && _stateMachine.InState<PlayingState>();
        }

        public bool IsRewinding()
        {
            return Initialized && _stateMachine.InState<RewindState>();
        }

        public bool IsPaused()
        {
            return Initialized && _stateMachine.InState<PauseState>();
        }

        public bool IsStopped()
        {
            return !Initialized || _stateMachine.InState<StoppedState>();
        }

        public bool ContainsTrigger(string tag)
        {
            return _triggers != null && _triggers.Any(t => t.CompareTag(tag));
        }

        public bool ContainsTag(object value)
        {
            return _tags != null && _tags.Contains(value);
        }

        public bool ContainsAllTags(IEnumerable<object> values)
        {
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
                return false;
            }

            foreach (var value in values)
            {
                if (!ContainsTag(value))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ContainsAnyTags(IEnumerable<object> values)
        {
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
                return false;
            }

            foreach (var value in values)
            {
                if (ContainsTag(value))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsMutable()
        {
            return IsStopped();
        }

        private bool IsInitializable()
        {
#if UNITY_EDITOR
            return Application.isPlaying;
#endif

            return true;
        }

        protected bool ValidateInitialized(bool targetState, bool logError = true)
        {
            var isValid = Initialized == targetState;
            if (!isValid && logError)
            {
                var reason = targetState ? "must be initialized" : "must be non-initialized";
                var message = "Not valid, " + reason;
                LogUtility.LogError(message);
            }

            return isValid;
        }

        protected bool ValidateMutable(bool targetState, bool logError = true)
        {
            var isMutable = IsMutable();
            var isValid = isMutable == targetState;
            if (!isValid && logError)
            {
                var reason = targetState ? "must be mutable" : "must be immutable";
                var message = "Not valid, " + reason;
                LogUtility.LogError(message);
            }

            return isValid;
        }
    }
}