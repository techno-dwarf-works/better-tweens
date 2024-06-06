using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class GridLayoutGroupExtensions
    {
        public static CellSizeLayoutGroupTween TweenCellSize(this GridLayoutGroup self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<CellSizeLayoutGroupTween, GridLayoutGroup, Vector2>(options, optionsMode);
        }

        public static ConstraintCountLayoutGroupTween TweenConstraintCount(this GridLayoutGroup self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ConstraintCountLayoutGroupTween, GridLayoutGroup, int>(options, optionsMode);
        }

        public static GridSpacingLayoutGroupTween TweenGridSpacing(this GridLayoutGroup self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<GridSpacingLayoutGroupTween, GridLayoutGroup, Vector2>(options, optionsMode);
        }

        public static GridSpacingLayoutGroupTween TweenGridSpacing(this GridLayoutGroup self, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<GridSpacingLayoutGroupTween, GridLayoutGroup>(options, optionsMode);
        }
    }
}