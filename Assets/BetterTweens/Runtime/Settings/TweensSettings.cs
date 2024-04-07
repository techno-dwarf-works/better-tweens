using Better.Internal.Core.Runtime;
using Better.ProjectSettings.Runtime;
using Better.Singletons.Runtime.Attributes;

namespace Better.Tweens.Runtime
{
    [ScriptableCreate(Path)]
    public class TweensSettings : ScriptableSettings<TweensSettings>
    {
        public const string Path = PrefixConstants.BetterPrefix + "/" + nameof(Tweens);
    }
}