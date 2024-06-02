using System.Collections.Generic;
using Better.Tweens.Runtime.Behaviours;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class InstantiateObjectTweenExtensions
    {
        public static IEnumerable<InstantiateObjectTween> SetBehaviour(this IEnumerable<InstantiateObjectTween> self, InstantiateBehaviour value)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetBehaviour(value);
            }

            return self;
        }

        public static IEnumerable<InstantiateObjectTween> SetBehaviour(this IEnumerable<InstantiateObjectTween> self, Transform parent, Vector3 position, Quaternion rotation)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetBehaviour(parent, position, rotation);
            }

            return self;
        }

        public static IEnumerable<InstantiateObjectTween> SetBehaviour(this IEnumerable<InstantiateObjectTween> self, Transform parent, Vector3 position)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetBehaviour(parent, position);
            }

            return self;
        }

        public static IEnumerable<InstantiateObjectTween> SetBehaviour(this IEnumerable<InstantiateObjectTween> self, Transform parent, bool inWorldSpace = false)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetBehaviour(parent, inWorldSpace);
            }

            return self;
        }

        public static IEnumerable<InstantiateObjectTween> SetBehaviour(this IEnumerable<InstantiateObjectTween> self, Vector3 position, Quaternion rotation)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetBehaviour(position, rotation);
            }

            return self;
        }

        public static IEnumerable<InstantiateObjectTween> SetBehaviour(this IEnumerable<InstantiateObjectTween> self, Vector3 position)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetBehaviour(position);
            }

            return self;
        }
    }
}