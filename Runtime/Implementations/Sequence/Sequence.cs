using System;
using System.Threading;
using Better.Attributes.Runtime.Misc;
using Better.Tweens.Runtime.Sequences.Channels;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public partial class Sequence : TweenCore
    {
        [HideLabel]
        [SerializeField] private GroupChannel<StageableChannel> _rootChannel;

        private CancellationTokenSource _operationTokenSource;
        
        public int ChannelsCount => _rootChannel.Count;

        public Sequence()
        {
            _rootChannel = new();
            AddChannel();
        }
    }
}