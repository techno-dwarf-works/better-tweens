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

        // TODO: Add attributes
        [SerializeField] private SettingsData _persistent = new();
        [SerializeField] private SettingsData _runtime = new();

        public SettingsData Persistent => _persistent;
        public SettingsData Runtime => _runtime;

        [RuntimeInitializeOnLoadMethod]
        private static void RuntimeInitializeOnLoadMethod()
        {
            Instance.ResetRuntimeToPersistent();
        }

        public void ResetRuntimeToPersistent()
        {
            _runtime ??= new();
            _runtime.Copy(_persistent);
        }
    }
}