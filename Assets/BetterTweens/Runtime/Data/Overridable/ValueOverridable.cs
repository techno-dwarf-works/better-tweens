using System;
using Better.Commons.Runtime.Interfaces;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
	[Serializable]
	public class ValueOverridable<TValue> : OverridableData<TValue>, ICloneable<ValueOverridable<TValue>>
		where TValue : struct
	{
		[SerializeField] private TValue _overridenValue;

		protected override TValue OverridenValue
		{
			get => _overridenValue;
			set => _overridenValue = value;
		}

		public ValueOverridable(TValue sourceValue, bool overriden, TValue overridenValue) : base(sourceValue, overriden)
		{
			_overridenValue = overridenValue;
		}

		public ValueOverridable()
		{
		}

		public ValueOverridable<TValue> Clone()
		{
			return new ValueOverridable<TValue>(SourceValue, Overriden, OverridenValue);
		}
	}
}