using Leopotam.EcsLite;
using Skillitronic.LeoECSLite.CollisionHandling.Behaviour;
using Skillitronic.LeoECSLite.CollisionHandling.Components;
using Skillitronic.LeoECSLite.Common;
using UnityEngine;

namespace Skillitronic.LeoECSLite.CollisionHandling
{
    public class CollisionSyncSystem : IEcsInitSystem,IEcsPostRunSystem
    {
        private EcsFilter _filter;
        private EcsPool<CollisionComponent> _collisionPool;
        private EcsPool<GameObjectReferenceComponent> _referencePool;

        public void Init(IEcsSystems systems)
        {
            EcsWorld world = systems.GetWorld();
            _filter = world.Filter<CollisionComponent>().Inc<GameObjectReferenceComponent>().End();
            _collisionPool = world.GetPool<CollisionComponent>();
            _referencePool = world.GetPool<GameObjectReferenceComponent>();
        }
        
        public void PostRun(IEcsSystems systems)
        {
            foreach (int i in _filter)
            {
                GameObject gameObject = _referencePool.Get(i).GameObject;
                CollisionBehaviour collisionBehaviour = gameObject.GetComponent<CollisionBehaviour>();

                if (!gameObject.activeInHierarchy)
                {
                    continue;
                }
                
                if (collisionBehaviour.Registered)
                {
                    continue;
                }
                
                collisionBehaviour.Register(OnCollidedWithTarget);
            }
        }
        
        private void OnCollidedWithTarget(int sender, CollisionData collisionData)
        {
            _collisionPool.Get(sender).CollisionData = collisionData;
        }
    }
}