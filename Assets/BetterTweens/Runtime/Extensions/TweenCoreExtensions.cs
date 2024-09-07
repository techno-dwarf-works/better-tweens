using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Triggers;
using Better.Tweens.Runtime.Utility;

#if BETTER_CONDITIONS
using Better.Conditions.Runtime;
#endif

namespace Better.Tweens.Runtime
{
    public static class TweenCoreExtensions
    {
        #region States

        public static IEnumerable<TweenCore> Enable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Enable();
            }

            return self;
        }

        public static IEnumerable<TweenCore> Sleep(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Sleep();
            }

            return self;
        }

        public static IEnumerable<TweenCore> Disable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Disable();
            }

            return self;
        }

        public static IEnumerable<TweenCore> Play(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Play();
            }

            return self;
        }

        public static IEnumerable<TweenCore> Rewind(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Rewind();
            }

            return self;
        }

        public static IEnumerable<TweenCore> Pause(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Pause();
            }

            return self;
        }

        public static IEnumerable<TweenCore> TogglePause(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.TogglePause();
            }

            return self;
        }

        public static IEnumerable<TweenCore> Stop(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Stop();
            }

            return self;
        }

        public static IEnumerable<TweenCore> InstantComplete(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.InstantComplete();
            }

            return self;
        }

        public static IEnumerable<TweenCore> InstantRewound(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.InstantRewound();
            }

            return self;
        }

        public static IEnumerable<TweenCore> Restart(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.Restart();
            }

            return self;
        }

        #endregion

        #region Loops

        public static IEnumerable<TweenCore> InstantCompleteLoop(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.InstantCompleteLoop();
            }

            return self;
        }

        public static IEnumerable<TweenCore> InstantCompleteLoops(this IEnumerable<TweenCore> self, int loopCount)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.InstantCompleteLoops(loopCount);
            }

            return self;
        }

        public static IEnumerable<TweenCore> InstantRewoundLoop(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.InstantRewoundLoop();
            }

            return self;
        }

        public static IEnumerable<TweenCore> InstantRewoundLoops(this IEnumerable<TweenCore> self, int loopCount)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.InstantRewoundLoops(loopCount);
            }

            return self;
        }

        #endregion

        #region Events

        public static TweenCore OnStateChanged(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.StateChanged += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnStateChanged(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnStateChanged(callback);
            }

            return self;
        }

        public static TweenCore OnActivityChanged(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.ActivityChanged += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnActivityChanged(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnActivityChanged(callback);
            }

            return self;
        }

        public static TweenCore OnEnabled(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Enabled += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnEnabled(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnEnabled();
            }

            return self;
        }

        public static TweenCore OnAsleep(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Asleep += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnAsleep(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnAsleep();
            }

            return self;
        }

        public static TweenCore OnDisabled(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Disabled += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnDisabled(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnDisabled();
            }

            return self;
        }

        public static TweenCore OnStarted(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Started += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnStarted(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnStarted();
            }

            return self;
        }

        public static TweenCore OnRunned(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Runned += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnRunned(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnRunned();
            }

            return self;
        }

        public static TweenCore OnPlaying(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Playing += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnPlaying(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnPlaying(callback);
            }

            return self;
        }

        public static TweenCore OnRewinding(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Rewinding += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnRewinding(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnRewinding(callback);
            }

            return self;
        }

        public static TweenCore OnUpdated(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Updated += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnUpdated(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnUpdated(callback);
            }

            return self;
        }

        public static TweenCore OnPaused(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Paused += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnPaused(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnPaused();
            }

            return self;
        }

        public static TweenCore OnStopped(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Stopped += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnStopped(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnStopped();
            }

            return self;
        }

        public static TweenCore OnCompleted(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Completed += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnCompleted(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnCompleted(callback);
            }

            return self;
        }

        public static TweenCore OnRewound(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Rewound += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnRewound(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnRewound(callback);
            }

            return self;
        }

        public static TweenCore OnLoopCompleted(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.LoopCompleted += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnLoopCompleted(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnLoopCompleted(callback);
            }

            return self;
        }

        public static TweenCore OnLoopRewound(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.LoopRewound += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnLoopRewound(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnLoopRewound(callback);
            }

            return self;
        }

        public static TweenCore OnBroken(this TweenCore self, Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                self.Broken += callback;
            }

            return self;
        }

        public static IEnumerable<TweenCore> OnBroken(this IEnumerable<TweenCore> self, Action callback)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.OnBroken(callback);
            }

            return self;
        }

        #endregion

        #region Building

        public static IEnumerable<TweenCore> SetLoopCount(this IEnumerable<TweenCore> self, int value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetLoopCount(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetInfinityLoop(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetInfinityLoop();
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetSleepingDuration(this IEnumerable<TweenCore> self, float value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetSleepingDuration(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetInfinitySleeping(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetInfinitySleeping();
            }

            return self;
        }

        public static IEnumerable<TweenCore> DependencyUnityTimeScale(this IEnumerable<TweenCore> self, bool depend)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.DependencyUnityTimeScale(depend);
            }

            return self;
        }

        public static IEnumerable<TweenCore> DependencyGlobalTimeScale(this IEnumerable<TweenCore> self, bool depend)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.DependencyGlobalTimeScale(depend);
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetLocalTimeScale(this IEnumerable<TweenCore> self, float value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetLocalTimeScale(value);
            }

            return self;
        }

        public static TweenCore SetCompletionAction(this TweenCore self, ActionType actionType)
        {
            var action = TweenCoreActionUtility.GetActionByType(actionType);
            return self.SetCompletionAction(action);
        }

        public static TweenCore SetCompletionAction<TAction>(this TweenCore self)
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            return self.SetCompletionAction(action);
        }

        public static IEnumerable<TweenCore> SetCompletionAction<TAction>(this IEnumerable<TweenCore> self)
            where TAction : TweenCoreAction, new()
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetCompletionAction<TAction>();
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetCompletionAction(this IEnumerable<TweenCore> self, TweenCoreAction value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetCompletionAction(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetCompletionAction(this IEnumerable<TweenCore> self, ActionType actionType)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetCompletionAction(actionType);
            }

            return self;
        }

        public static TweenCore SetRewoundAction<TAction>(this TweenCore self)
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            return self.SetRewoundAction(action);
        }

        public static TweenCore SetRewoundAction(this TweenCore self, ActionType actionType)
        {
            var action = TweenCoreActionUtility.GetActionByType(actionType);
            return self.SetRewoundAction(action);
        }

        public static IEnumerable<TweenCore> SetRewoundAction<TAction>(this IEnumerable<TweenCore> self)
            where TAction : TweenCoreAction, new()
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetRewoundAction<TAction>();
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetRewoundAction(this IEnumerable<TweenCore> self, ActionType actionType)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetRewoundAction(actionType);
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetRewoundAction(this IEnumerable<TweenCore> self, TweenCoreAction value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetRewoundAction(value);
            }

            return self;
        }

        public static TweenCore RemoveTriggers(this TweenCore self, string id)
        {
            return self.RemoveTriggers(trigger => trigger.CompareId(id));
        }

        public static TweenCore AddTriggers(this TweenCore self, IEnumerable<Trigger> triggers)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(triggers))
            {
                return self;
            }

            foreach (var trigger in triggers)
            {
                self.AddTrigger(trigger);
            }

            return self;
        }

        public static IEnumerable<TweenCore> AddTriggers(this IEnumerable<TweenCore> self, IEnumerable<Trigger> triggers)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(triggers))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.AddTriggers(triggers);
            }

            return self;
        }

        public static IEnumerable<TweenCore> AddTrigger(this IEnumerable<TweenCore> self, Trigger trigger)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(trigger))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.AddTrigger(trigger);
            }

            return self;
        }

        public static TweenCore AddTrigger(this TweenCore self, TweenCoreAction action, CancellationToken cancellationToken, string id = Trigger.UndefinedId)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return null;
            }

            if (!ValidationUtility.ValidateNullReference(action))
            {
                return self;
            }

            var trigger = new CancellationTokenTrigger(id, action, cancellationToken);
            return self.AddTrigger(trigger);
        }

        public static TweenCore AddTrigger<TAction>(this TweenCore self, CancellationToken cancellationToken, string id = Trigger.UndefinedId)
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            return self.AddTrigger(action, cancellationToken, id);
        }

#if BETTER_CONDITIONS

        public static TweenCore AddTrigger(this TweenCore self, TweenCoreAction action, Condition condition, string id = Trigger.UndefinedId)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return null;
            }

            if (!ValidationUtility.ValidateNullReference(action))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(condition))
            {
                return self;
            }

            var trigger = new ConditionTrigger(id, action, condition);
            return self.AddTrigger(trigger);
        }

        public static TweenCore AddTrigger<TAction>(this TweenCore self, Condition condition, string id = Trigger.UndefinedId)
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            return self.AddTrigger(action, condition, id);
        }

        public static TweenCore AddTrigger<TCondition>(this TweenCore self, TweenCoreAction action, string id = Trigger.UndefinedId)
            where TCondition : Condition, new()
        {
            var condition = new TCondition();
            return self.AddTrigger(action, condition, id);
        }

        public static TweenCore AddTrigger<TAction, TCondition>(this TweenCore self, string id = Trigger.UndefinedId)
            where TAction : TweenCoreAction, new()
            where TCondition : Condition, new()
        {
            var condition = new TCondition();
            return self.AddTrigger<TAction>(condition, id);
        }

#endif

        public static TweenCore SetTrigger(this TweenCore self, Trigger value)
        {
            return self.ClearTriggers().AddTrigger(value);
        }

        public static IEnumerable<TweenCore> SetTrigger(this IEnumerable<TweenCore> self, Trigger value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetTrigger(value);
            }

            return self;
        }

        public static TweenCore SetTriggers(this TweenCore self, IEnumerable<Trigger> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return self;
            }

            self.ClearTriggers();
            foreach (var value in values)
            {
                self.AddTrigger(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetTriggers(this IEnumerable<TweenCore> self, IEnumerable<Trigger> values)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(values))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetTriggers(values);
            }

            return self;
        }

        public static IEnumerable<TweenCore> RemoveTriggers(this IEnumerable<TweenCore> self, Predicate<Trigger> predicate)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.RemoveTriggers(predicate);
            }

            return self;
        }

        public static IEnumerable<TweenCore> RemoveTriggers(this IEnumerable<TweenCore> self, string id)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.RemoveTriggers(id);
            }

            return self;
        }

        public static IEnumerable<TweenCore> ClearTriggers(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.ClearTriggers();
            }

            return self;
        }

        public static TweenCore AddTags(this TweenCore self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return self;
            }

            foreach (var value in values)
            {
                self.AddTag(value);
            }

            return self;
        }

        public static bool ContainsAllTags(this TweenCore self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return false;
            }

            foreach (var value in values)
            {
                if (!self.ContainsTag(value))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ContainsAnyTags(this TweenCore self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return false;
            }

            foreach (var value in values)
            {
                if (self.ContainsTag(value))
                {
                    return true;
                }
            }

            return false;
        }

        public static TweenCore RemoveTags(this TweenCore self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return self;
            }

            foreach (var value in values)
            {
                self.RemoveTag(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> AddTag(this IEnumerable<TweenCore> self, object value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.AddTag(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> AddTags(this IEnumerable<TweenCore> self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.AddTags(values);
            }

            return self;
        }

        public static TweenCore SetTag(this TweenCore self, object value)
        {
            return self.ClearTags().AddTag(value);
        }

        public static IEnumerable<TweenCore> SetTag(this IEnumerable<TweenCore> self, object value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetTag(value);
            }

            return self;
        }

        public static TweenCore SetTags(this TweenCore self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return self;
            }

            self.ClearTags();
            foreach (var value in values)
            {
                self.AddTag(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> SetTags(this IEnumerable<TweenCore> self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            if (!ValidationUtility.ValidateNullReference(values))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.SetTags(values);
            }

            return self;
        }

        public static IEnumerable<TweenCore> RemoveTag(this IEnumerable<TweenCore> self, object value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.RemoveTag(value);
            }

            return self;
        }

        public static IEnumerable<TweenCore> ClearTags(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.ClearTags();
            }

            return self;
        }

        public static IEnumerable<TweenCore> As(this IEnumerable<TweenCore> self, TweenCore source)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return self;
            }

            foreach (var tweenCore in self)
            {
                tweenCore.As(source);
            }
            
            return self;
        }

        #endregion

        #region Validation

        public static bool AllEnabled(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsEnabled())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyEnabled(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsEnabled())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllSleeping(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsSleeping())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnySleeping(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsSleeping())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllDisabled(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsDisabled())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyDisabled(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsDisabled())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllRunnable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsRunnable())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyRunnable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsRunnable())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllRunning(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsRunning())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyRunning(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsRunning())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllPlayable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsPlayable())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyPlayable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsPlayable())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllPlaying(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsPlaying())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyPlaying(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsPlaying())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllRewindable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsRewindable())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyRewindable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsRewindable())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllRewinding(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsRewinding())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyRewinding(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsRewinding())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllRewound(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsRewound())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyRewound(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsRewound())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllPausable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsPausable())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyPausable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsPausable())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllPaused(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsPaused())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyPaused(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsPaused())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllStoppable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsStoppable())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyStoppable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsStoppable())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllStopped(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsStopped())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyStopped(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsStopped())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllCompletable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsCompletable())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyCompletable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsCompletable())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllCompleted(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsCompleted())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyCompleted(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsCompleted())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllContainsTriggerWith(this IEnumerable<TweenCore> self, string id)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.ContainsTriggerWith(id))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyContainsTriggerWith(this IEnumerable<TweenCore> self, string id)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.ContainsTriggerWith(id))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllContainsTag(this IEnumerable<TweenCore> self, object value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.ContainsTag(value))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyContainsTag(this IEnumerable<TweenCore> self, object value)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.ContainsTag(value))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllContainsAllTags(this IEnumerable<TweenCore> self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.ContainsAllTags(values))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyContainsAllTags(this IEnumerable<TweenCore> self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.ContainsAllTags(values))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllContainsAnyTags(this IEnumerable<TweenCore> self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.ContainsAnyTags(values))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyContainsAnyTags(this IEnumerable<TweenCore> self, IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.ContainsAnyTags(values))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllMutable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsMutable())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyMutable(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsMutable())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AllBroken(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (!tweenCore.IsBroken())
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AnyBroken(this IEnumerable<TweenCore> self)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return false;
            }

            foreach (var tweenCore in self)
            {
                if (tweenCore.IsBroken())
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Awaiters

        public static Task AwaitActivityChange(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenActivityChangeAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitActivityChange(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitActivityChange(cancellationToken)).ToArray();
        }

        public static Task AwaitAsleep(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenAsleepAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitAsleep(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitAsleep(cancellationToken)).ToArray();
        }

        public static Task AwaitCompletion(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenCompletionAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitCompletion(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitCompletion(cancellationToken)).ToArray();
        }

        public static Task AwaitDisable(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenDisableAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitDisable(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitDisable(cancellationToken)).ToArray();
        }

        public static Task AwaitEnable(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenEnableAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitEnable(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitEnable(cancellationToken)).ToArray();
        }

        public static Task AwaitPaused(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenPausedAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitPaused(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitPaused(cancellationToken)).ToArray();
        }

        public static Task AwaitPlaying(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenPlayingAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitPlaying(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitPlaying(cancellationToken)).ToArray();
        }

        public static Task AwaitPlayStarted(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenPlayStartedAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitPlayStarted(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitPlayStarted(cancellationToken)).ToArray();
        }

        public static Task AwaitRewinding(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenRewindingAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitRewinding(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitRewinding(cancellationToken)).ToArray();
        }

        public static Task AwaitRewindStarted(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenRewindStartedAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitRewindStarted(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitRewindStarted(cancellationToken)).ToArray();
        }

        public static Task AwaitRewound(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenRewoundAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitRewound(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitRewound(cancellationToken)).ToArray();
        }

        public static Task AwaitRun(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenRunAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitRun(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitRun(cancellationToken)).ToArray();
        }

        public static Task AwaitStateChange(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenStateChangeAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitStateChange(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitStateChange(cancellationToken)).ToArray();
        }

        public static Task AwaitStopped(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenStoppedAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitStopped(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitStopped(cancellationToken)).ToArray();
        }

        public static Task AwaitUpdate(this TweenCore self, CancellationToken cancellationToken = default)
        {
            return new TweenUpdateAwaiter(self, cancellationToken).Task;
        }

        public static Task[] AwaitUpdate(this IEnumerable<TweenCore> self, CancellationToken cancellationToken = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<Task>();
            }

            return self.Select(tween => tween.AwaitUpdate(cancellationToken)).ToArray();
        }

        #endregion

        #region Tweening

        public static LocalTimeScaleCoreTween TweenLocalTimeScale(this TweenCore self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalTimeScaleCoreTween, TweenCore, float, float>(duration, options, optionsMode);
        }

        public static IEnumerable<LocalTimeScaleCoreTween> TweensLocalTimeScale(this IEnumerable<TweenCore> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalTimeScaleCoreTween>();
            }

            var tweens = new List<LocalTimeScaleCoreTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalTimeScale(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        #endregion
    }
}