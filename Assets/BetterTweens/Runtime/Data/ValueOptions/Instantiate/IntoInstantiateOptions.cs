using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class IntoInstantiateOptions : InstantiateOptions
    {
        [SerializeField] private Transform _parent;
        [SerializeField] private bool _inWorldSpace;

        public Transform Parent => _parent;
        public bool InWorldSpace => _inWorldSpace;

        public IntoInstantiateOptions(Transform parent, bool inWorldSpace = false)
        {
            _parent = parent;
            _inWorldSpace = inWorldSpace;
        }

        protected IntoInstantiateOptions() : this(null)
        {
        }

        public override UnityEngine.Object Instantiate(UnityEngine.Object original)
        {
            return UnityEngine.Object.Instantiate(original, Parent, InWorldSpace);
        }
    }
}