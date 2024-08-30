using System;

namespace Better.Tweens.Runtime.Actions
{
    [Serializable]
    public abstract class SingleAction<TSource> : TweenCoreAction
        where TSource : SingleAction<TSource>, new()
    {
        private static TSource _instance;

        public static TSource Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new();
                }

                return _instance;
            }
        }

        public sealed override TweenCoreAction Clone()
        {
            return this;
        }
    }
}