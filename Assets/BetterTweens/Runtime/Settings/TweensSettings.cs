using Better.Internal.Core.Runtime;
using Better.ProjectSettings.Runtime;
using Better.Singletons.Runtime.Attributes;
using Better.Tweens.Runtime.Settings;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [ScriptableCreate(Path)]
    public class TweensSettings : ScriptableSettings<TweensSettings>
    {
        public const string Path = PrefixConstants.BetterPrefix + "/" + nameof(Tweens);

        [SerializeField] private SettingsProperty<bool> _independentTimeScale = new(true);
        [SerializeField] private SettingsProperty<float> _timeScaleProperty = new(1f);

        public float TimeScale
        {
            get => _timeScaleProperty.Value;
            set => _timeScaleProperty.Value = value;
        }

        [RuntimeInitializeOnLoadMethod]
        private static void RuntimeInitializeOnLoadMethod()
        {
            Instance.ResetValues();
        }

        private void ResetValues()
        {
            _timeScaleProperty.ResetValue();
        }
    }
}