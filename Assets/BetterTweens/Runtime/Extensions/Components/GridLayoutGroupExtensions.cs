using System.Collections.Generic;
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

        public static IEnumerable<CellSizeLayoutGroupTween> TweensCellSize(this IEnumerable<GridLayoutGroup> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<CellSizeLayoutGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCellSize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ConstraintCountLayoutGroupTween TweenConstraintCount(this GridLayoutGroup self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ConstraintCountLayoutGroupTween, GridLayoutGroup, int>(options, optionsMode);
        }

        public static IEnumerable<ConstraintCountLayoutGroupTween> TweensConstraintCount(this IEnumerable<GridLayoutGroup> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ConstraintCountLayoutGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenConstraintCount(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static GridSpacingLayoutGroupTween TweenGridSpacing(this GridLayoutGroup self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<GridSpacingLayoutGroupTween, GridLayoutGroup, Vector2>(options, optionsMode);
        }

        public static IEnumerable<GridSpacingLayoutGroupTween> TweensGridSpacing(this IEnumerable<GridLayoutGroup> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<GridSpacingLayoutGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenGridSpacing(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static GridSpacingLayoutGroupTween TweenGridSpacing(this GridLayoutGroup self, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<GridSpacingLayoutGroupTween, GridLayoutGroup>(options, optionsMode);
        }

        public static IEnumerable<GridSpacingLayoutGroupTween> TweensGridSpacing(this IEnumerable<GridLayoutGroup> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<GridSpacingLayoutGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenGridSpacing(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}