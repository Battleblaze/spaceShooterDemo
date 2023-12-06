using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public readonly partial struct AsteroidAspect : IAspect
{
    public readonly Entity Entity;
    private readonly RefRW<LocalTransform> transfrom;
    private readonly RefRO<AsteroidProperties> properties;
    public int NumberToSpawn => properties.ValueRO.NumberOfAsteroids;

    public Entity entity => properties.ValueRO.AsteroidPrefab;

}
