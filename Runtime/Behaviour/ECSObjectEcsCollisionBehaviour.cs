using Skillitronic.LeoECSLite.Common;

namespace Skillitronic.LeoECSLite.Physics.Collisions
{
    public sealed class ECSObjectEcsCollisionBehaviour : ECSCollisionBehaviour
    {
        private void OnCollisionEnter(UnityEngine.Collision other)
        {
            if (!other.collider.attachedRigidbody)
            {
                return;
            }

            if (other.gameObject.TryGetComponent(out EntityReferenceHolder entityReferenceHolder))
            {
                OnCollision(Entity, new CollisionData(entityReferenceHolder.Entity, true));
            }
        }

        private void OnCollisionExit(UnityEngine.Collision other)
        {
            if (!other.collider.attachedRigidbody)
            {
                return;
            }

            if (other.gameObject.TryGetComponent(out EntityReferenceHolder entityReferenceHolder))
            {
                OnCollision(Entity, new CollisionData(entityReferenceHolder.Entity, false));
            }
        }
    }
}