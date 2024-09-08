using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Better.Attributes.Runtime.Select;
using Better.Commons.Runtime.Extensions;
using UnityEngine;

namespace Better.Tweens.Runtime.Sequences.Stages
{
    [Serializable]
    public class TweensStage : Stage
    {
        [Select]
        [SerializeReference] private List<Tween> _tweens;

        public TweensStage()
        {
            _tweens = new();
        }

        public void AddTween(Tween tween)
        {
            _tweens.Add(tween);
        }

        public override void Start()
        {
            base.Start();

            _tweens.SetCompletionAction(ActionType.Pause);
            _tweens.SetRewoundAction(ActionType.Stop);
        }

        public override async Task PlayAsync(CancellationToken cancellationToken)
        {
            await base.PlayAsync(cancellationToken);
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            await _tweens.Play().AwaitPlaying(cancellationToken).WhenAll();
        }

        public override async Task RewindAsync(CancellationToken cancellationToken)
        {
            await base.RewindAsync(cancellationToken);
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            await _tweens.Rewind().AwaitRewinding(cancellationToken).WhenAll();
        }

        public override void InstantComplete()
        {
            base.InstantComplete();

            _tweens.Play().InstantComplete();
        }

        public override void InstantRewound()
        {
            base.InstantRewound();

            _tweens.Rewind().InstantRewound();
        }

        public override void Pause()
        {
            base.Pause();

            _tweens.Pause();
        }

        public override void Stop()
        {
            base.Stop();

            _tweens.Stop();
        }

        public override bool IsCompleted()
        {
            return _tweens.AllCompleted();
        }

        public override bool IsRewound()
        {
            return _tweens.AllRewound();
        }

        public override Stage Clone()
        {
            var clone = new TweensStage();
            clone._tweens = _tweens.CloneByActivator().ToList();
            
            return clone;
        }
    }
}