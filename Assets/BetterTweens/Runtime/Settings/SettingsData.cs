using System;
using Better.Attributes.Runtime.Select;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Logs;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime.Settings
{
    [Serializable]
    public class SettingsData
    {
        [SerializeField] private float _globalTimeScale;
        [SerializeField] private bool _dependUnityTimeScale;
        [SerializeField] private bool _dependGlobalTimeScale;
        [SerializeField] private SleepingDuration _sleepingDuration;
        [SerializeField] private LogLevel _logLevel;
        [SerializeField] private bool _safeMode;

        [Select]
        [SerializeReference] private Ease _ease;

        [Select]
        [SerializeReference] private TweenCoreAction _completionAction;

        public float GlobalTimeScale
        {
            get => _globalTimeScale;
            set => _globalTimeScale = value;
        }

        public bool DependUnityTimeScale
        {
            get => _dependUnityTimeScale;
            set => _dependUnityTimeScale = value;
        }

        public bool DependGlobalTimeScale
        {
            get => _dependGlobalTimeScale;
            set => _dependGlobalTimeScale = value;
        }

        public LogLevel LogLevel
        {
            get => _logLevel;
            set => _logLevel = value;
        }

        public bool SafeMode
        {
            get => _safeMode;
            set => _safeMode = value;
        }

        public Ease Ease => _ease;
        public TweenCoreAction CompletionAction => _completionAction;
        public SleepingDuration SleepingDuration => _sleepingDuration;

        public SettingsData()
        {
            _globalTimeScale = 1f;
            _dependGlobalTimeScale = true;
            _dependUnityTimeScale = true;
            _logLevel = LogLevel.Info;
            _safeMode = true;
            _ease = new LinearEase();
            _sleepingDuration = new();
            _completionAction = TweenCore.DefaultCompletionAction;
        }

        public void SetEase(Ease value)
        {
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            _ease = value;
        }

        public void SetCompletionAction(TweenCoreAction value)
        {
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            _completionAction = value;
        }

        public void SetCompletionAction<TAction>()
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            SetCompletionAction(action);
        }

        public void SetEase(EaseType type, EaseMode mode = EaseMode.InOut)
        {
            var ease = EaseUtility.GetEaseByType(type, mode);
            SetEase(ease);
        }

        public void SetEase(AnimationCurve animationCurve)
        {
            var ease = new CurveEase(animationCurve);
            SetEase(ease);
        }

        public void SetEase(Func<float, float> func)
        {
            var ease = new FuncEase(func);
            SetEase(ease);
        }

        public void Copy(SettingsData source)
        {
            _globalTimeScale = source._globalTimeScale;
            _dependUnityTimeScale = source._dependUnityTimeScale;
            _dependGlobalTimeScale = source._dependGlobalTimeScale;
            _logLevel = source._logLevel;
            _safeMode = source._safeMode;
            _ease = source._ease.Clone();
            _sleepingDuration = source._sleepingDuration.Clone();
            _completionAction = source._completionAction.Clone();
        }
    }
}