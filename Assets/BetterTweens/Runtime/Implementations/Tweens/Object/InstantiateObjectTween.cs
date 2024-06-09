using System;
using System.Text;
using Better.Attributes.Runtime.Select;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Behaviours;
using Better.Tweens.Runtime.Utility;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class InstantiateObjectTween : BoolTween<Object>
    {
        // TODO: Add ForgetOnStart ???

        [Select]
        [SerializeReference] private InstantiateBehaviour _behaviour;

        private Object _instance;

        public InstantiateObjectTween SetBehaviour(InstantiateBehaviour value)
        {
            if (ValidationUtility.ValidateNullReference(value))
            {
                _behaviour = value;
            }

            return this;
        }

        public InstantiateObjectTween SetBehaviour(Transform parent, Vector3 position, Quaternion rotation)
        {
            var behaviour = new IntoWorldInstantiateBehaviour(parent, position, rotation);
            return SetBehaviour(behaviour);
        }

        public InstantiateObjectTween SetBehaviour(Transform parent, Vector3 position)
        {
            return SetBehaviour(parent, position, Quaternion.identity);
        }

        public InstantiateObjectTween SetBehaviour(Transform parent, bool inWorldSpace = false)
        {
            var behaviour = new IntoInstantiateBehaviour(parent, inWorldSpace);
            return SetBehaviour(behaviour);
        }

        public InstantiateObjectTween SetBehaviour(Vector3 position, Quaternion rotation)
        {
            var behaviour = new WorldInstantiateBehaviour(position, rotation);
            return SetBehaviour(behaviour);
        }

        public InstantiateObjectTween SetBehaviour(Vector3 position)
        {
            return SetBehaviour(position, Quaternion.identity);
        }

        protected override bool GetCurrentValue()
        {
            return _instance != null;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (value && _instance == null)
            {
                _instance = _behaviour.Instantiate(Target);
            }
            else if (value && _instance != null)
            {
                _instance.Destroy();
            }
        }

        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendLine()
                .AppendFieldLine(nameof(_behaviour), _behaviour);
        }
    }
}