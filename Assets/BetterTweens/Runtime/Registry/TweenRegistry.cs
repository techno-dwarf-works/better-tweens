namespace Better.Tweens.Runtime
{
    internal static class TweenRegistry
    {
        public static TweenCore TweenCore;

        static TweenRegistry()
        {
        }

        public static void Register(TweenCore tweenCore)
        {
            TweenCore = tweenCore;
        }

        public static void Unregister(TweenCore tweenCore)
        {
            TweenCore = null;
        }
    }
}