using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct AsteroidProperties : IComponentData
{
    public int NumberOfAsteroids;

    public Entity AsteroidPrefab;
}
