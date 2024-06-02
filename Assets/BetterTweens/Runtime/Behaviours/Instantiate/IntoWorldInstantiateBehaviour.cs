using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Behaviours
{
    [Serializable]
    public class IntoWorldInstantiateBehaviour : WorldInstantiateBehaviour
    {
        [SerializeField] private Transform _parent;
        public Transform Parent => _parent;

        public IntoWorldInstantiateBehaviour(Transform parent, Vector3 position, Quaternion rotation) : base(position, rotation)
        {
            _parent = parent;
        }

        public IntoWorldInstantiateBehaviour(Transform parent, Vector3 position) : this(parent, position, Quaternion.identity)
        {
        }

        protected IntoWorldInstantiateBehaviour()
        {
        }

        public override UnityEngine.Object Instantiate(UnityEngine.Object original)
        {
            return UnityEngine.Object.Instantiate(original, Position, Rotation, Parent);
        }
    }
}