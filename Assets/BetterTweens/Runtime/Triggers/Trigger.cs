using System;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class Trigger
    {
        protected readonly TweenCore TweenCore;
        protected readonly TriggerActionType ActionType;

        public Trigger(TweenCore tweenCore, TriggerActionType actionType)
        {
            TweenCore = tweenCore;
            ActionType = actionType;
        }

        public bool TryInvoke()
        {
            if (ActionReadiness() && ConditionMet())
            {
                ApplyAction();
                return true;
            }

            return false;
        }

        private bool ActionReadiness()
        {
            return ActionType switch
            {
                TriggerActionType.Play => !TweenCore.IsPlaying(),
                TriggerActionType.Rewind => !TweenCore.IsRewinding(),
                TriggerActionType.Pause => !TweenCore.IsPaused(),
                TriggerActionType.TogglePause => !TweenCore.IsStopped(),
                TriggerActionType.Stop => !TweenCore.IsStopped(),
                TriggerActionType.Complete => !TweenCore.IsStopped(),
                TriggerActionType.Restart => true,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        protected abstract bool ConditionMet();

        private void ApplyAction()
        {
            switch (ActionType)
            {
                case TriggerActionType.Play:
                    TweenCore.Play();
                    break;
                case TriggerActionType.Rewind:
                    TweenCore.Rewind();
                    break;
                case TriggerActionType.Pause:
                    TweenCore.Pause();
                    break;
                case TriggerActionType.TogglePause:
                    TweenCore.TogglePause();
                    break;
                case TriggerActionType.Stop:
                    TweenCore.Stop();
                    break;
                case TriggerActionType.Restart:
                    TweenCore.Restart();
                    break;
                case TriggerActionType.Complete:
                    TweenCore.Complete();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public abstract class Trigger<TSource> : Trigger
        where TSource : class
    {
        protected readonly TSource Source;

        public Trigger(TweenCore tweenCore, TriggerActionType actionType, TSource source) : base(tweenCore, actionType)
        {
            Source = source;
        }

        public bool IsSource(TSource value)
        {
            return Source == value;
        }
    }
}