using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Behaviours
{
    [Serializable]
    public class WorldInstantiateBehaviour : InstantiateBehaviour
    {
        [SerializeField] private Vector3 _position;
        [SerializeField] private Quaternion _rotation;

        public Vector3 Position => _position;
        public Quaternion Rotation => _rotation;

        public WorldInstantiateBehaviour(Vector3 position, Quaternion rotation)
        {
            _position = position;
            _rotation = rotation;
        }

        public WorldInstantiateBehaviour(Vector3 position) : this(position, Quaternion.identity)
        {
        }

        public WorldInstantiateBehaviour() : this(Vector3.zero)
        {
        }

        public override UnityEngine.Object Instantiate(UnityEngine.Object original)
        {
            return UnityEngine.Object.Instantiate(original, Position, Rotation);
        }
    }
}