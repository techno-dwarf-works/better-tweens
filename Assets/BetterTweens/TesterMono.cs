using UnityEngine;

namespace Better.Tweens.Runtime.TESTS
{
    public class TesterMono : MonoBehaviour
    {
        [SerializeField] private TesterCore _tester = new();

        private void OnValidate()
        {
            _tester.OnValidate();
        }
    }
}