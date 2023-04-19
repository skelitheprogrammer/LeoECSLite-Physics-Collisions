using System;
using Skillitronic.LeoECSLite.Common;
using UnityEngine;

namespace Skillitronic.LeoECSLite.CollisionHandling.Behaviour
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(EntityReferenceHolder))]
    public abstract class CollisionBehaviour : MonoBehaviour
    {
        private EntityReferenceHolder _entityReference;
        private event Action<int, CollisionData> Collision;

        public bool Registered => Collision != null;

        protected int EntityReference => _entityReference.Entity;

        private void Awake()
        {
            _entityReference = GetComponent<EntityReferenceHolder>();
        }

        private void OnDisable()
        {
            Collision = null;
        }

        public void Register(Action<int, CollisionData> onTrigger)
        {
            Collision = onTrigger;
        }

        protected void OnCollision(int entityReference, CollisionData collisionData)
        {
            Collision.Invoke(entityReference, collisionData);
        }
    }
}