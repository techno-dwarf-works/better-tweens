using System;
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

        public SettingsData()
        {
            _globalTimeScale = 1f;
            _dependGlobalTimeScale = true;
            _dependUnityTimeScale = true;
            _logLevel = LogLevel.Info;
        }

        public void Copy(SettingsData source)
        {
            _globalTimeScale = source._globalTimeScale;
            _dependUnityTimeScale = source._dependUnityTimeScale;
            _dependGlobalTimeScale = source._dependGlobalTimeScale;
            _logLevel = source._logLevel;
            _safeMode = source._safeMode;
        }
    }
}