using Better.Internal.Core.Runtime;
using Better.ProjectSettings.EditorAddons;
using Better.Tweens.Runtime;
using UnityEditor;

namespace Better.Tweens.EditorAddons
{
    public class TweensSettingsProvider : DefaultProjectSettingsProvider<TweensSettings>
    {
        public TweensSettingsProvider() : base(TweensSettings.Path)
        {
            keywords = new[] { "tweens", "sequence", "animation" };
        }

        [MenuItem(TweensSettings.Path + "/" + PrefixConstants.HighlightPrefix, false, 999)]
        private static void Highlight()
        {
            SettingsService.OpenProjectSettings(ProjectPath + TweensSettings.Path);
        }
    }
}