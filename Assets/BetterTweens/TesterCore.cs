using System;
using UnityEngine;

namespace Better.Tweens.Runtime.TESTS
{
    [Serializable]
    public class TesterCore
    {
        [Header("TRIGGERS")]
        [SerializeField] private bool _play;

        [SerializeField] private bool _rewind;
        [SerializeField] private bool _pause;
        [SerializeField] private bool _stop;
        [SerializeField] private bool _complete;
        [SerializeField] private bool _restart;
        [SerializeField] private bool _stress;

        [Header("PARAMS")]
        [SerializeField] private float _duration;

        [SerializeField] private float _from;
        [SerializeField] private float _to;

        // [Header("SERIALIZATION")]
        // private DebugTween _tween11111111111111;

        public void OnValidate()
        {
            if (!Application.isPlaying)
            {
                // TODO
                return;
            }

            // if (_tween11111111111111 == null)
            // {
                // Debug.Log("Hmmm, null tween.");
                // _tween11111111111111 = new DebugTween();
                
                // _tween11111111111111.SetTarget(_from)
                    // .SetOptions(_to)
                    // .SetDuration(_duration);
            // }

            // if (_play)
            // {
                // _play = false;
                // _tween11111111111111.Play();
            // }

            // if (_pause)
            // {
                // _pause = false;
                // _tween11111111111111.Pause();
            // }

            // if (_complete)
            // {
                // _complete = false;
                // _tween11111111111111.Complete();
            // }

            // if (_stop)
            // {
                // _stop = false;
                // _tween11111111111111.Stop();
            // }

            // if (_rewind)
            // {
                // _rewind = false;
                // _tween11111111111111.Rewind();
            // }

            // if (_restart)
            // {
                // _restart = false;
                // _tween11111111111111.Restart();
            // }

            // if (_stress)
            // {
                // _stress = false;
                // Stress();
            // }
        }

        private void Stress()
        {
            // _tween11111111111111.Pause();
            // _tween11111111111111.Play();
            // _tween11111111111111.Pause();
            // _tween11111111111111.Play();
            // _tween11111111111111.Complete();
            // _tween11111111111111.Pause();
            // _tween11111111111111.Pause();
            // _tween11111111111111.Play();
            // _tween11111111111111.Play();
            // _tween11111111111111.Pause();
            // _tween11111111111111.Stop();
            // _tween11111111111111.Play();
            // _tween11111111111111.Complete();
            // _tween11111111111111.Restart();
            // _tween11111111111111.Stop();
        }
    }
}