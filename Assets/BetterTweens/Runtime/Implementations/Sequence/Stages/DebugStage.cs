using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Sequences.Stages
{
    [Serializable]
    public class DebugStage : SimpleStage
    {
        [SerializeField] private string _message;

        public DebugStage()
        {
            SetMessage(nameof(DebugStage));
        }

        public void SetMessage(string message)
        {
            _message = message;
        }
        
        protected override void Execute()
        {
            Debug.Log(_message);
        }
    }
}