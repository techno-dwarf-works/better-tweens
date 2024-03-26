using UnityEngine;

namespace Better.Tweens.Runtime.BetterTweens.Runtime
{
    [CreateAssetMenu(menuName = "Create TesterSO", fileName = "TesterSO", order = 0)]
    public class TesterSO : ScriptableObject
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
        // [SerializeField] private float _duration;
        [SerializeField] private float _from;

        [SerializeField] private float _to;

        private TestTween _tween;

        private void OnValidate()
        {
            if (!Application.isPlaying)
            {
                // TODO
                return;
            }

            if (_tween == null)
            {
                _tween = new TestTween(_from);
                _tween.SetOptions(_to);
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
                _tween.Complete();
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
        }

        private void Stress()
        {
            _tween.Pause();
            _tween.Play();
            _tween.Pause();
            _tween.Play();
            _tween.Complete();
            _tween.Pause();
            _tween.Pause();
            _tween.Play();
            _tween.Play();
            _tween.Pause();
            _tween.Stop();
            _tween.Play();
            _tween.Complete();
            _tween.Restart();
            _tween.Stop();
        }
    }
}