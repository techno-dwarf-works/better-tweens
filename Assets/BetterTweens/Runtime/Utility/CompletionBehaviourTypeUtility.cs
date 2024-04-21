using System;

namespace Better.Tweens.Runtime
{
    public static class CompletionBehaviourTypeUtility
    {
        public static CompletionBehaviour GetBehaviourByType(CompletionBehaviourType type)
        {
            return type switch
            {
                CompletionBehaviourType.Rewind => new RewindCompletionBehaviour(),
                CompletionBehaviourType.Restart => new RestartCompletionBehaviour(),
                CompletionBehaviourType.Pause => new PauseCompletionBehaviour(),
                CompletionBehaviourType.Stop => new StopCompletionBehaviour(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}