using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Better.Attributes.Runtime.Select;
using Better.Tweens.Runtime.Sequences.Stages;
using UnityEngine;

namespace Better.Tweens.Runtime.Sequences.Channels
{
    [Serializable]
    public class StageableChannel : Channel
    {
        [Select]
        [SerializeReference] private List<Stage> _stages;

        private int _currentStageIndex;

        public bool IsEmpty => _stages.Count == 0;

        public int CurrentStageIndex
        {
            get => _currentStageIndex;
            set => _currentStageIndex = Mathf.Clamp(value, 0, _stages.Count - 1);
        }

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
            CurrentStageIndex = 0;

            for (var i = 0; i < _stages.Count; i++)
            {
                _stages[i].Start();
            }
        }

        public override async Task PlayAsync(CancellationToken cancellationToken)
        {
            for (; CurrentStageIndex < _stages.Count; CurrentStageIndex++)
            {
                await _stages[CurrentStageIndex].PlayAsync(cancellationToken);
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
            }
        }

        public override async Task RewindAsync(CancellationToken cancellationToken)
        {
            if (IsEmpty)
            {
                return;
            }

            for (; CurrentStageIndex >= 0; CurrentStageIndex--)
            {
                await _stages[CurrentStageIndex].RewindAsync(cancellationToken);
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
            }
        }

        public override void InstantComplete()
        {
            for (; CurrentStageIndex < _stages.Count; CurrentStageIndex++)
            {
                _stages[CurrentStageIndex].InstantComplete();
            }
        }

        public override void InstantRewound()
        {
            if (IsEmpty)
            {
                return;
            }

            for (; CurrentStageIndex >= 0; CurrentStageIndex--)
            {
                _stages[CurrentStageIndex].InstantRewound();
            }
        }

        public override void Pause()
        {
            if (IsEmpty)
            {
                return;
            }

            _stages[CurrentStageIndex].Pause();
        }

        public override void Stop()
        {
            for (var i = 0; i < _stages.Count; i++)
            {
                _stages[i].Stop();
            }
        }

        public override bool IsCompleted()
        {
            if (IsEmpty)
            {
                return true;
            }

            return CurrentStageIndex == _stages.Count - 1 && _stages[CurrentStageIndex].IsCompleted();
        }

        public override bool IsRewound()
        {
            if (IsEmpty)
            {
                return true;
            }

            return CurrentStageIndex == 0 && _stages[CurrentStageIndex].IsRewound();
        }
    }
}