using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class AsteroidSpawnerMono : MonoBehaviour
{
    public int NumberOfAsteroids;

    public GameObject AsterodPrefab;
}

public class AsterodSpawnerBaker : Baker<AsteroidSpawnerMono>
{
    public override void Bake(AsteroidSpawnerMono authoring)
    {
        AddComponent(new AsteroidProperties
        {
            NumberOfAsteroids = authoring.NumberOfAsteroids,
            AsteroidPrefab = GetEntity(authoring.AsterodPrefab),
        });      
    }
}