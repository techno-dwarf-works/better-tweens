using System;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public abstract class InstantiateOptions
    {
        public abstract UnityEngine.Object Instantiate(UnityEngine.Object original);
    }
}