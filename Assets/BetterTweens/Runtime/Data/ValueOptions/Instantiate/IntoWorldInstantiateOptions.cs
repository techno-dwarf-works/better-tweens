using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class IntoWorldInstantiateOptions : WorldInstantiateOptions
    {
        [SerializeField] private Transform _parent;
        public Transform Parent => _parent;

        public IntoWorldInstantiateOptions(Transform parent, Vector3 position, Quaternion rotation) : base(position, rotation)
        {
            _parent = parent;
        }

        public IntoWorldInstantiateOptions(Transform parent, Vector3 position) : this(parent, position, Quaternion.identity)
        {
        }

        public IntoWorldInstantiateOptions(Transform parent) : this(parent, Vector3.zero, Quaternion.identity)
        {
        }

        protected IntoWorldInstantiateOptions() : this(null)
        {
        }

        public override UnityEngine.Object Instantiate(UnityEngine.Object original)
        {
            return UnityEngine.Object.Instantiate(original, Position, Rotation, Parent);
        }
    }
}