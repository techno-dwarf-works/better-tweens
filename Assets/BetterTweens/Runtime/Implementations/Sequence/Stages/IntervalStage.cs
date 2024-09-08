using System;
using System.Threading;
using System.Threading.Tasks;
using Better.Commons.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime.Sequences.Stages
{
    [Serializable]
    public class IntervalStage : Stage
    {
        [Min(default)]
        [SerializeField] private float _duration;

        private float _leftDuration;

        public void AddDuration(float value)
        {
            if (value <= 0f)
            {
                return;
            }

            _duration += value;
        }

        public override void Start()
        {
            base.Start();

            _leftDuration = _duration;
        }

        public override async Task PlayAsync(CancellationToken cancellationToken)
        {
            await base.PlayAsync(cancellationToken);

            var rootTime = Time.time;
            await TaskUtility.WaitForSeconds(_leftDuration, cancellationToken);

            var passedTime = Time.time - rootTime;
            _leftDuration -= passedTime;
        }

        public override async Task RewindAsync(CancellationToken cancellationToken)
        {
            await base.PlayAsync(cancellationToken);

            var rootTime = Time.time;
            var waitDuration = _duration - _leftDuration;
            await TaskUtility.WaitForSeconds(waitDuration, cancellationToken);

            var passedTime = Time.time - rootTime;
            _leftDuration += passedTime;
        }

        public override void InstantComplete()
        {
            base.InstantComplete();

            _leftDuration = 0f;
        }

        public override void InstantRewound()
        {
            base.InstantRewound();

            _leftDuration = _duration;
        }

        public override void Stop()
        {
            base.Stop();

            _leftDuration = 0f;
        }

        public override bool IsCompleted()
        {
            return _leftDuration <= 0f;
        }

        public override bool IsRewound()
        {
            return _leftDuration >= _duration;
        }

        public override Stage Clone()
        {
            var clone = new IntervalStage();
            clone._duration = _duration;
            
            return clone;
        }
    }
}