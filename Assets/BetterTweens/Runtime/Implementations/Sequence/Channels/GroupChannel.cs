using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Better.Attributes.Runtime.Misc;
using Better.Commons.Runtime.Extensions;
using UnityEngine;

namespace Better.Tweens.Runtime.Sequences.Channels
{
    [Serializable]
    public class GroupChannel<TChannel> : Channel
        where TChannel : Channel, new()
    {
        [HideLabel]
        [SerializeField] private List<TChannel> _channels;

        public int Count => _channels.Count;

        public GroupChannel()
        {
            _channels = new();
        }

        public void AddChannel()
        {
            var channel = new TChannel();
            _channels.Add(channel);
        }

        public override void PrependCallback(Action callback)
        {
            var channel = GetOrAddEditingChannel();
            channel.PrependCallback(callback);
        }

        public override void AppendCallback(Action callback)
        {
            var channel = GetOrAddEditingChannel();
            channel.AppendCallback(callback);
        }

        public override void PrependInterval(float duration)
        {
            var channel = GetOrAddEditingChannel();
            channel.PrependInterval(duration);
        }

        public override void AppendInterval(float duration)
        {
            var channel = GetOrAddEditingChannel();
            channel.AppendInterval(duration);
        }

        public override void AppendTween(Tween tween)
        {
            var channel = GetOrAddEditingChannel();
            channel.AppendTween(tween);
        }

        public override void PrependTween(Tween tween)
        {
            var channel = GetOrAddEditingChannel();
            channel.PrependTween(tween);
        }

        public override void JoinTween(Tween tween)
        {
            var channel = GetOrAddEditingChannel();
            channel.JoinTween(tween);
        }

        public override void PrependLog(string message)
        {
            var channel = GetOrAddEditingChannel();
            channel.PrependLog(message);
        }

        public override void AppendLog(string message)
        {
            var channel = GetOrAddEditingChannel();
            channel.AppendLog(message);
        }

        public override void Start()
        {
            foreach (var channel in _channels)
            {
                channel.Start();
            }
        }

        public override Task PlayAsync(CancellationToken cancellationToken)
        {
            var tasks = new Task[Count];
            for (var i = 0; i < _channels.Count; i++)
            {
                tasks[i] = _channels[i].PlayAsync(cancellationToken);
            }

            return tasks.WhenAll();
        }

        public override Task RewindAsync(CancellationToken cancellationToken)
        {
            var tasks = new Task[Count];
            for (var i = 0; i < _channels.Count; i++)
            {
                tasks[i] = _channels[i].RewindAsync(cancellationToken);
            }

            return tasks.WhenAll();
        }

        public override void InstantComplete()
        {
            foreach (var channel in _channels)
            {
                channel.InstantComplete();
            }
        }

        public override void InstantRewound()
        {
            foreach (var channel in _channels)
            {
                channel.InstantRewound();
            }
        }

        public override void Pause()
        {
            foreach (var channel in _channels)
            {
                channel.Pause();
            }
        }

        public override void Stop()
        {
            foreach (var channel in _channels)
            {
                channel.Stop();
            }
        }

        public override bool IsCompleted()
        {
            foreach (var channel in _channels)
            {
                if (!channel.IsCompleted())
                {
                    return false;
                }
            }

            return true;
        }

        public override bool IsRewound()
        {
            foreach (var channel in _channels)
            {
                if (!channel.IsRewound())
                {
                    return false;
                }
            }

            return true;
        }

        private Channel GetOrAddEditingChannel()
        {
            if (Count == 0)
            {
                AddChannel();
            }

            return _channels.Last();
        }
    }
}