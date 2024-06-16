using System;
using Better.Attributes.Runtime.Select;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class EaseTester : MonoBehaviour
    {
        [Select]
        [SerializeReference] private Ease _ease;

        [SerializeField] private LineRenderer _lineRenderer;
        [SerializeField] private int _keyframes = 100;

        private Ease _cached;

        private void Awake()
        {
            _lineRenderer.positionCount = _keyframes;
        }

        private void Update()
        {
            for (int i = 0; i < _keyframes; i++)
            {
                var time = (i + 1f) / _keyframes;
                var value = _ease.Evaluate(time);
                _lineRenderer.SetPosition(i, new Vector3(i, value * 100f));
            }
        }
    }
}