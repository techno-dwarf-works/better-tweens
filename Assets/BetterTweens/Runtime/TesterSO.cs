using UnityEngine;

namespace Better.Tweens.Runtime.BetterTweens.Runtime
{
    [CreateAssetMenu(menuName = "Create TesterSO", fileName = "TesterSO", order = 0)]
    public class TesterSO : ScriptableObject
    {
        [Header("TRIGGERS")]
        [SerializeField] private bool _play;
        [SerializeField] private bool _pause;
        [SerializeField] private bool _rewind;
        [SerializeField] private bool _restart;
        [SerializeField] private bool _stress;

        [Header("PARAMS")]
        [SerializeField] private float _duration;

        [SerializeField] private float _from;
        [SerializeField] private float _to;

        private Tween _tween;

        private void OnValidate()
        {
            _tween ??= new TestTween(_from, _to, _duration);
            
            if (_play)
            {
                _play = false;
                Play();
            }
            
            if (_pause)
            {
                _pause = false;
                Pause();
            }
            
            if (_rewind)
            {
                _rewind = false;
                Rewind();
            }

            if (_restart)
            {
                _restart = false;
                Restart();
            }

            if (_stress)
            {
                _stress = false;
                Stress();
            }
        }

        private void Restart()
        {
            _tween.Restart();
        }

        private void Play()
        {
            _tween.Play();
        }

        private void Pause()
        {
            _tween.Pause();
        }

        private void Rewind()
        {
            _tween.Rewing();
        }

        private void Stress()
        {
            _tween.Pause();
            _tween.Play();
            _tween.Pause();
            _tween.Play();
            _tween.Kill();
            _tween.Pause();
            _tween.Pause();
            _tween.Play();
            _tween.Play();
            _tween.Pause();
            _tween.Kill();
            _tween.Play();
            _tween.Kill();
            _tween.Restart();
            _tween.Kill();
        }
    }
}