using UnityEngine;

namespace Better.Tweens.Runtime.TESTS
{
    [CreateAssetMenu(menuName = "Create TesterSO", fileName = "TesterSO", order = 0)]
    public class TesterSO : ScriptableObject
    {
        [SerializeField] private TesterCore _tester = new();

        private void OnValidate()
        {
            _tester.OnValidate();
        }
    }
}