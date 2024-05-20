using System;
using Better.Tweens.Runtime.Actions;

namespace Better.Tweens.Runtime.Utility
{
    public static class TweenCoreActionUtility
    {
        public static TweenCoreAction GetActionByType(ActionType type)
        {
            return type switch
            {
                ActionType.Enable => EnableAction.Instance,
                ActionType.Sleep => SleepAction.Instance,
                ActionType.Disable => DisableAction.Instance,
                ActionType.Play => PlayAction.Instance,
                ActionType.Rewind => RewindAction.Instance,
                ActionType.Pause => PauseAction.Instance,
                ActionType.TogglePause => TogglePauseAction.Instance,
                ActionType.Stop => StopAction.Instance,
                ActionType.Restart => RestartAction.Instance,
                ActionType.InstantComplete => InstantCompleteAction.Instance,
                ActionType.InstantRewound => InstantRewoundAction.Instance,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}