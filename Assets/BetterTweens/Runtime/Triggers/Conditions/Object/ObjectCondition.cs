﻿using UnityEngine;

namespace Better.Tweens.Runtime.Triggers
{
    public abstract class ObjectCondition<TSource> : TriggerCondition<TSource>
        where TSource : Object
    {
        public ObjectCondition(TSource source) : base(source)
        {
        }

        protected bool IsNullSource()
        {
            return Source != null;
        }
    }
}