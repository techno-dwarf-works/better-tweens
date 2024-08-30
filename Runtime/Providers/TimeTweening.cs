namespace Better.Tweens.Runtime
{
    public static class TimeTweening
    {
        public static ScaleTimeTween TweenTimeScale(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new ScaleTimeTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }
    }
}