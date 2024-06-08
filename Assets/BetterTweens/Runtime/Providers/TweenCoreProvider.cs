using Better.Attributes.Runtime.Select;
using Better.Tweens.Runtime.Actions;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class TweenCoreProvider : MonoBehaviour
    {
        [Select]
        [SerializeReference] private TweenCore _source;

        [Select]
        [SerializeReference] private TweenCoreAction _enableAction;

        [Select]
        [SerializeReference] private TweenCoreAction _disableAction;

        public TweenCore Source
        {
            get => _source;
            set => _source = value;
        }

        public TweenCoreAction EnableAction
        {
            get => _enableAction;
            set => _enableAction = value;
        }

        public TweenCoreAction DisableAction
        {
            get => _disableAction;
            set => _disableAction = value;
        }

        private void OnEnable()
        {
            _enableAction?.TryInvoke(Source);
        }

        private void OnDisable()
        {
            _enableAction?.TryInvoke(Source);
        }

        private void Reset()
        {
            _enableAction = new PlayAction();
            _disableAction = new StopAction();
        }
    }
}