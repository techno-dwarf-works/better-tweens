using System;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using Better.Tweens.Runtime.Logs;
using UnityEngine;

namespace Better.Tweens.Runtime.Settings
{
    [Serializable]
    public class SettingsData
    {
        [SerializeField] private float _globalTimeScale;
        [SerializeField] private bool _dependUnityTimeScale;
        [SerializeField] private bool _dependGlobalTimeScale;
        [SerializeField] private Ease _ease;
        [SerializeField] private LogLevel _logLevel;
        [SerializeField] private bool _safeMode;

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

        public SettingsData()
        {
            _globalTimeScale = 1f;
            _dependGlobalTimeScale = true;
            _dependUnityTimeScale = true;
            _ease = new LinearEase();
            _logLevel = LogLevel.Info;
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

        public void SetEase(EaseType type)
        {
            var ease = EaseUtility.GetEaseByType(type);
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
        }
    }
}