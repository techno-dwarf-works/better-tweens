using System;

namespace Better.Tweens.Runtime.Behaviours
{
    [Serializable]
    public abstract class InstantiateBehaviour
    {
        public abstract UnityEngine.Object Instantiate(UnityEngine.Object original);
    }
}