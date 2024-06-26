using Better.Internal.Core.Runtime;
using Better.ProjectSettings.Runtime;
using Better.Singletons.Runtime.Attributes;
using Better.Tweens.Runtime.Settings;

namespace Better.Tweens.Runtime
{
    [ScriptableCreate(Path)]
    public class TweensSettings : ScriptableSettings<TweensSettings, SettingsData>
    {
        public const string Path = PrefixConstants.BetterPrefix + "/" + nameof(Tweens);
    }
}