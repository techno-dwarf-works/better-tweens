using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class TestTween : Tween
    {
        private float from;
        private float to;

        public TestTween(float from, float to, float duration) : base(duration)
        {
            this.from = from;
            this.to = to;
        }

        private float prevLog;
        internal override void ApplyState_Tween()
        {
            if(Progress is > 0f and < 1f && Mathf.Abs(Progress- prevLog) < 0.1f) return;
            prevLog = Progress;
            
            var currentVal = Mathf.Lerp(from, to, Progress);
            Debug.Log($"apply: {currentVal}\n({from}-{to})");
        }

        protected override void OnCompleted()
        {
            Debug.Log("OnCompleted invoked");
        }

        protected override void OnKilled()
        {
            Debug.Log("OnKilled invoked");
        }
    }
}