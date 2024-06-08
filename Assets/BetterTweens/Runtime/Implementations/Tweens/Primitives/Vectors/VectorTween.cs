using System;
using System.Collections.Generic;
using System.Text;
using Better.Commons.Runtime.Extensions;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class VectorTween<TVector, TConstraint> : Tween<TVector>
    {
        // TODO: Add method Free constnds

        [SerializeField] private List<TConstraint> _axisConstraints;
        [SerializeField] private bool _spherical;

        public bool Spherical => _spherical;
        public bool HasConstraints => !_axisConstraints.IsNullOrEmpty();
        protected List<TConstraint> Constraints => _axisConstraints;

        public VectorTween<TVector, TConstraint> SetSpherical(bool spherical = true)
        {
            _spherical = spherical;
            return this;
        }

        public VectorTween<TVector, TConstraint> AddConstraint(TConstraint constraint)
        {
            _axisConstraints ??= new();
            _axisConstraints.Add(constraint);

            return this;
        }

        public bool HasConstraint(TConstraint constraint)
        {
            if (_axisConstraints == null)
            {
                return false;
            }

            return _axisConstraints.Contains(constraint);
        }

        public VectorTween<TVector, TConstraint> RemoveConstraint(TConstraint constraint)
        {
            _axisConstraints?.Remove(constraint);

            return this;
        }

        public VectorTween<TVector, TConstraint> RemoveConstraints()
        {
            _axisConstraints?.Clear();
            return this;
        }

        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendLine()
                .AppendFieldLine(nameof(Spherical), Spherical)
                .AppendFieldLine(nameof(HasConstraints), HasConstraints);

            if (HasConstraints)
            {
                string constrainsValue = string.Join(", ", Constraints);
                stringBuilder.AppendFieldLine(nameof(Constraints), constrainsValue);
            }
        }
    }

    [Serializable]
    public abstract class VectorTween<TTarget, TVector, TConstraint> : TargetTween<TTarget, TVector>
        where TTarget : class
    {
        // TODO: Add method Free constnds

        [SerializeField] private List<TConstraint> _axisConstraints;
        [SerializeField] private bool _spherical;

        public bool Spherical => _spherical;
        public bool HasConstraints => !_axisConstraints.IsNullOrEmpty();
        protected List<TConstraint> Constraints => _axisConstraints;

        public VectorTween<TTarget, TVector, TConstraint> SetSpherical(bool spherical = true)
        {
            _spherical = spherical;
            return this;
        }

        public VectorTween<TTarget, TVector, TConstraint> AddConstraint(TConstraint constraint)
        {
            _axisConstraints ??= new();
            _axisConstraints.Add(constraint);

            return this;
        }

        public bool HasConstraint(TConstraint constraint)
        {
            if (_axisConstraints == null)
            {
                return false;
            }

            return _axisConstraints.Contains(constraint);
        }

        public VectorTween<TTarget, TVector, TConstraint> RemoveConstraint(TConstraint constraint)
        {
            _axisConstraints?.Remove(constraint);

            return this;
        }

        public VectorTween<TTarget, TVector, TConstraint> RemoveConstraints()
        {
            _axisConstraints?.Clear();
            return this;
        }

        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendLine()
                .AppendFieldLine(nameof(Spherical), Spherical)
                .AppendFieldLine(nameof(HasConstraints), HasConstraints);

            if (HasConstraints)
            {
                string constrainsValue = string.Join(", ", Constraints);
                stringBuilder.AppendFieldLine(nameof(Constraints), constrainsValue);
            }
        }
    }
}