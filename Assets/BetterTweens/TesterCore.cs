using System;
using Better.Conditions.Runtime;
using Better.Tweens.Runtime.Actions;
using UnityEngine;

namespace Better.Tweens.Runtime.TESTS
{
    [Serializable]
    public class TesterCore
    {
        [SerializeField] private MonoBehaviour _triggerMonoTarget;

        [Header("TRIGGERS")]
        [SerializeField] private bool _play;

        [SerializeField] private bool _rewind;
        [SerializeField] private bool _pause;
        [SerializeField] private bool _stop;
        [SerializeField] private bool _complete;
        [SerializeField] private bool _restart;
        [SerializeField] private bool _stress;
        [SerializeField] private bool _enable;
        [SerializeField] private bool _sleep;
        [SerializeField] private bool _disable;
        [SerializeField] private bool _addTrigger;

        [Header("SERIALIZATION")]
        [SerializeField] private DebugTween _tween;

        public void OnValidate()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            if (_tween == null)
            {
                Debug.Log("Hmmm, null tween.");
                _tween = new DebugTween();
            }

            if (_play)
            {
                _play = false;
                _tween.Play();
            }

            if (_pause)
            {
                _pause = false;
                _tween.Pause();
            }

            if (_complete)
            {
                _complete = false;
                _tween.InstantComplete();
            }

            if (_stop)
            {
                _stop = false;
                _tween.Stop();
            }

            if (_rewind)
            {
                _rewind = false;
                _tween.Rewind();
            }

            if (_restart)
            {
                _restart = false;
                _tween.Restart();
            }

            if (_stress)
            {
                _stress = false;
                Stress();
            }

            if (_enable)
            {
                _enable = false;
                _tween.Enable();
            }

            if (_sleep)
            {
                _sleep = false;
                _tween.Sleep();
            }

            if (_disable)
            {
                _disable = false;
                _tween.Disable();
            }

            if (_addTrigger)
            {
                _addTrigger = false;

                var enableCondition = new EnabledBehaviourCondition(_triggerMonoTarget, true);
                var disableCondition = new EnabledBehaviourCondition(_triggerMonoTarget, false);
                _tween.AddTrigger<PlayAction>(enableCondition);
                _tween.AddTrigger<StopAction>(disableCondition);
            }
        }

        private void Stress()
        {
            _tween.Pause();
            _tween.Play();
            _tween.Pause();
            _tween.Play();
            _tween.InstantComplete();
            _tween.Pause();
            _tween.Pause();
            _tween.Play();
            _tween.Play();
            _tween.Pause();
            _tween.Stop();
            _tween.Play();
            _tween.InstantComplete();
            _tween.Restart();
            _tween.Stop();
        }
    }
}