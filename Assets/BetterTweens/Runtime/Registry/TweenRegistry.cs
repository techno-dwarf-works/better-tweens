namespace Better.Tweens.Runtime
{
    internal static class TweenRegistry
    {
        public static Tween TweenCore;
        static TweenRegistry()
        {
        }

        public static void Register(Tween tweenCore)
        {
            TweenCore = tweenCore;
        }

        public static void Unregister(Tween tweenCore)
        {
            TweenCore = null;
        }
    }
}