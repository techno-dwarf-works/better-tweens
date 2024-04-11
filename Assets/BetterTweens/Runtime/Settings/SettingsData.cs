using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Settings
{
    [Serializable]
    public class SettingsData
    {
        [SerializeField] private float _globalTimeScale;
        [SerializeField] private bool _dependUnityTimeScale;
        [SerializeField] private bool _dependGlobalTimeScale;

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


        public SettingsData()
        {
            _globalTimeScale = 1f;
            _dependGlobalTimeScale = true;
            _dependUnityTimeScale = true;
        }

        public void Copy(SettingsData source)
        {
            _globalTimeScale = source._globalTimeScale;
            _dependUnityTimeScale = source._dependUnityTimeScale;
            _dependGlobalTimeScale = source._dependGlobalTimeScale;
        }
    }
}