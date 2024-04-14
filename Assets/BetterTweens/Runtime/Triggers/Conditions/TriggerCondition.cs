using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class TriggerCondition
    {
        public abstract bool Validate();
    }

    public abstract class TriggerCondition<TSource> : TriggerCondition
    {
        protected readonly TSource Source;

        public TriggerCondition(TSource source)
        {
            if (source == null)
            {
                var message = $"{nameof(source)} cannot be null";
                LogUtility.LogException(message);
            }

            Source = source;
        }
    }
}