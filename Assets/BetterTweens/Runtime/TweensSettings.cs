using Better.Internal.Core.Runtime;
using Better.ProjectSettings.Runtime;
using Better.Singletons.Runtime.Attributes;
using Better.Tweens.Runtime.Data;

namespace Better.Tweens.Runtime
{
    [ScriptableCreate(Path)]
    public class TweensSettings : ScriptableSettings<TweensSettings, SettingsData>
    {
        public const float MinTime = 0f;
        public const string Path = PrefixConstants.BetterPrefix + "/" + nameof(Tweens);
    }
}