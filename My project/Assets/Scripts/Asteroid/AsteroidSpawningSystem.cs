using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Collections;

public partial struct AsteroidSpawningSystem : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<AsteroidProperties>();
    }

    public void OnUpdate(ref SystemState state)
    {
        var asteroidAspect = SystemAPI.GetAspect<AsteroidAspect>(SystemAPI.GetSingletonEntity<AsteroidProperties>());
        var ecb = new EntityCommandBuffer(Allocator.Temp);

        for (int i = 0; i < asteroidAspect.NumberToSpawn; i++)
        {
            var newAsteroid = ecb.Instantiate(asteroidAspect.entity);
        }
        ecb.Playback(state.EntityManager);
    }

    public void OnDestroy(ref SystemState state)
    {

    }
}
