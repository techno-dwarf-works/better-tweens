using System;

namespace Better.Tweens.Runtime
{
    public static class CompletionBehaviourUtility
    {
        public static CompletionBehaviour GetBehaviourByType(CompletionType type)
        {
            return type switch
            {
                CompletionType.Rewind => new RewindCompletionBehaviour(),
                CompletionType.Restart => new RestartCompletionBehaviour(),
                CompletionType.Pause => new PauseCompletionBehaviour(),
                CompletionType.Stop => new StopCompletionBehaviour(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}