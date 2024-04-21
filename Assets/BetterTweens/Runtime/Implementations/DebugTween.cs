using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DebugTween : Tween<float>
    {
        public override UpdateMode UpdateMode { get; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Log("initialized");
        }

        protected override void OnStateChanged()
        {
            base.OnStateChanged();

            Log("state changed");
        }


        protected internal override void OnRunned()
        {
            base.OnRunned();

            Log("on runned");
        }

        protected internal override void OnStarted()
        {
            base.OnStarted();

            Log("started");
        }

        protected internal override void OnPlay()
        {
            base.OnPlay();

            Log("play");
        }

        protected internal override void OnRewind()
        {
            base.OnRewind();

            Log("rewind");
        }


        protected override float CalculateRelativeFrom(float to, float options)
        {
            throw new NotImplementedException();

            Log("calculate from (relative)");
        }

        protected override float CalculateTo(float from, float options, OptionsMode optionsMode)
        {
            throw new NotImplementedException();

            Log("calculated to");
        }

        protected override float GetCurrentValue()
        {
            throw new NotImplementedException();

            Log("getting current value");
        }

        protected override float GetRelativeOptions(float from, float to)
        {
            throw new NotImplementedException();

            Log("getting relative options");
        }

        protected override void EvaluateState(float fromValue, float toValue, float time)
        {
            throw new NotImplementedException();

            Log("evaluate state");
        }

        protected override void OnLoopCompleted()
        {
            base.OnLoopCompleted();

            Log("on loop completed");
        }

        protected override void OnLoopRewound()
        {
            base.OnLoopRewound();

            Log("on loop rewound");
        }

        protected override void OnUpdated()
        {
            base.OnUpdated();

            Log("on updated");
        }

        protected internal override void OnPaused()
        {
            base.OnPaused();

            Log("pause");
        }

        protected internal override void OnStopped()
        {
            base.OnStopped();

            Log("stopped");
        }

        protected override void OnCompleted()
        {
            base.OnCompleted();

            Log("completed");
        }

        protected override void OnRewound()
        {
            base.OnRewound();

            Log("rewound");
        }


        private void Log(string message)
        {
            LogUtility.LogDebug(message);
        }

        public override string ToString()
        {
            return base.ToString();
            xxxxxxxxxxx
        }
    }
}