using System;

namespace Better.Tweens.Runtime
{
    public partial class Sequence
    {
        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is Sequence sequenceSource)
            {
                _rootChannel = sequenceSource._rootChannel.Clone();
            }

            return base.As(source);
        }

        public Sequence AddChannel()
        {
            if (ValidateMutable(true))
            {
                _rootChannel.AddChannel();
            }

            return this;
        }

        public Sequence PrependCallback(Action callback)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.PrependCallback(callback);
            }

            return this;
        }

        public Sequence AppendCallback(Action callback)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.AppendCallback(callback);
            }

            return this;
        }

        public Sequence PrependInterval(float duration)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.PrependInterval(duration);
            }

            return this;
        }

        public Sequence AppendInterval(float duration)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.AppendInterval(duration);
            }

            return this;
        }

        public Sequence PrependTween(Tween tween)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.PrependTween(tween);
            }

            return this;
        }

        public Sequence AppendTween(Tween tween)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.AppendTween(tween);
            }

            return this;
        }

        public Sequence JoinTween(Tween tween)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.JoinTween(tween);
            }

            return this;
        }

        public Sequence PrependLog(string message)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.PrependLog(message);
            }

            return this;
        }

        public Sequence AppendLog(string message)
        {
            if (ValidateMutable(true))
            {
                _rootChannel.AppendLog(message);
            }

            return this;
        }
    }
}