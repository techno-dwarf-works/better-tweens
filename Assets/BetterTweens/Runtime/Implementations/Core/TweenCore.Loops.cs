using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected virtual void CompleteLoop()
        {
            OnLoopCompleted();
        }

        protected void CompleteLoops(int loopCount)
        {
            for (int i = 0; i < loopCount; i++)
            {
                if (IsStopped() || IsCompleted())
                {
                    return;
                }

                CompleteLoop();
            }
        }

        protected virtual void OnLoopCompleted()
        {
            ActionUtility.Invoke(LoopCompleted);

            if (IsCompleted())
            {
                OnCompleted();
            }
        }

        protected void OnLoopsCompleted(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (!IsPlaying()) return;

                OnLoopCompleted();
            }
        }

        protected virtual void RewoundLoop___xxxxxxxxxx() // TODO: Name
        {
            if (IsStopped() || IsRewound())
            {
                return;
            }

            OnLoopRewound();
        }

        protected void RewoundLoops______xxxxxxx(int loopCount) // TODO: Name 
        {
            for (int i = 0; i < loopCount; i++)
            {
                if (IsStopped() || IsRewound())
                {
                    return;
                }

                RewoundLoop___xxxxxxxxxx();
            }
        }

        protected virtual void OnLoopRewound()
        {
            ActionUtility.Invoke(LoopRewound);

            if (IsRewound())
            {
                OnRewound();
            }
        }

        protected void OnLoopsRewound(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (!IsRewinding()) return;

                OnLoopRewound();
            }
        }
    }
}