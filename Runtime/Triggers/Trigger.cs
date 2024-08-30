using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class Trigger
    {
        public const string UndefinedId = nameof(UndefinedId);
        public string Id { get; }

        protected Trigger(string id)
        {
            if (id.IsNullOrEmpty())
            {
                var message = $"{nameof(id)} cannot be null or empty, will be used {nameof(UndefinedId)}({UndefinedId})";
                LogUtility.LogWarning(message);
                id = UndefinedId;
            }

            Id = id;
        }

        public virtual void Rebuild()
        {
        }

        public abstract bool Invoke(TweenCore tweenCore);

        public bool CompareId(string value)
        {
            return Id == value;
        }
    }
}