using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Better.Attributes.Runtime.Select;
using Better.Commons.Runtime.Interfaces;
using Better.Tweens.Runtime.Sequences.Stages;
using UnityEngine;

namespace Better.Tweens.Runtime.Sequences.Channels
{
    [Serializable]
    public class StageableChannel : Channel, ICloneable<StageableChannel>
    {
        [Select]
        [SerializeReference] private List<Stage> _stages;

        private int _currentStageIndex;

        public bool IsEmpty => _stages.Count == 0;

        public StageableChannel()
        {
            _stages = new();
        }

        public override void PrependCallback(Action callback)
        {
            var stage = PrependStage<ActionStage>();
            stage.On(callback);
        }

        public override void AppendCallback(Action callback)
        {
            var stage = AppendStage<ActionStage>();
            stage.On(callback);
        }

        public override void PrependInterval(float duration)
        {
            var stage = PrependStage<IntervalStage>();
            stage.AddDuration(duration);
        }

        public override void AppendInterval(float duration)
        {
            var stage = AppendStage<IntervalStage>();
            stage.AddDuration(duration);
        }

        public override void AppendTween(Tween tween)
        {
            var stage = AppendStage<TweensStage>(false);
            stage.AddTween(tween);
        }

        public override void PrependTween(Tween tween)
        {
            var stage = PrependStage<TweensStage>(false);
            stage.AddTween(tween);
        }

        public override void JoinTween(Tween tween)
        {
            var stage = AppendStage<TweensStage>();
            stage.AddTween(tween);
        }

        public override void PrependLog(string message)
        {
            var stage = PrependStage<DebugStage>(false);
            stage.SetMessage(message);
        }

        public override void AppendLog(string message)
        {
            var stage = AppendStage<DebugStage>(false);
            stage.SetMessage(message);
        }

        private TStage PrependStage<TStage>(bool useExisting = true)
            where TStage : Stage, new()
        {
            if (useExisting && !IsEmpty && _stages.First() is TStage stage)
            {
                return stage;
            }

            stage = new TStage();
            _stages.Insert(0, stage);
            return stage;
        }

        private TStage AppendStage<TStage>(bool useExisting = true)
            where TStage : Stage, new()
        {
            if (useExisting && !IsEmpty && _stages.Last() is TStage stage)
            {
                return stage;
            }

            stage = new TStage();
            _stages.Add(stage);
            return stage;
        }

        public override void Start()
        {
            _currentStageIndex = 0;

            foreach (var stage in _stages)
            {
                stage.Start();
            }
        }

        public override async Task PlayAsync(CancellationToken cancellationToken)
        {
            if (IsEmpty)
            {
                return;
            }

            var remainingCount = GetRemainingStageCount();
            for (var i = 0; i <= remainingCount; i++)
            {
                await GetCurrentStage().PlayAsync(cancellationToken);
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                MoveNextStage();
            }
        }

        public override async Task RewindAsync(CancellationToken cancellationToken)
        {
            if (IsEmpty)
            {
                return;
            }

            var passedStageCount = GetPassedStageCount();
            for (var i = 0; i <= passedStageCount; i++)
            {
                await GetCurrentStage().RewindAsync(cancellationToken);
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                MovePreviousStage();
            }
        }

        public override void InstantComplete()
        {
            if (IsEmpty)
            {
                return;
            }

            var remainingCount = GetRemainingStageCount();
            for (var i = 0; i <= remainingCount; i++)
            {
                GetCurrentStage().InstantComplete();
                MoveNextStage();
            }
        }

        public override void InstantRewound()
        {
            if (IsEmpty)
            {
                return;
            }

            var passedStageCount = GetPassedStageCount();
            for (var i = 0; i <= passedStageCount; i++)
            {
                GetCurrentStage().InstantRewound();
                MovePreviousStage();
            }
        }

        public override void Pause()
        {
            if (IsEmpty)
            {
                return;
            }

            GetCurrentStage().Pause();
        }

        public override void Stop()
        {
            foreach (var stage in _stages)
            {
                stage.Stop();
            }
        }

        public override bool IsCompleted()
        {
            if (IsEmpty)
            {
                return true;
            }

            return GetRemainingStageCount() == 0 && GetCurrentStage().IsCompleted();
        }

        public override bool IsRewound()
        {
            if (IsEmpty)
            {
                return true;
            }

            return GetPassedStageCount() == 0 && GetCurrentStage().IsRewound();
        }

        private int GetPassedStageCount()
        {
            return _currentStageIndex;
        }

        private int GetRemainingStageCount()
        {
            if (IsEmpty)
            {
                return 0;
            }

            return _stages.Count - _currentStageIndex - 1;
        }

        private Stage GetCurrentStage()
        {
            return _stages[_currentStageIndex];
        }

        private void MoveNextStage()
        {
            _currentStageIndex++;
            _currentStageIndex = Mathf.Min(_currentStageIndex, _stages.Count - 1);
        }

        private void MovePreviousStage()
        {
            _currentStageIndex--;
            _currentStageIndex = Mathf.Max(_currentStageIndex, 0);
        }

        public StageableChannel Clone()
        {
            var clone = new StageableChannel();
            foreach (var stage in _stages)
            {
                var stageClone = stage.Clone();
                clone._stages.Add(stageClone);
            }

            return clone;
        }
    }
}