using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;


[BurstCompile]
public class AsteroidSpawner : MonoBehaviour
{
    
    [SerializeField] public GameObject asteroidPrefab;
    public float spawnInterval = 3f;
    public float spawnRadius = 10f;


    [BurstCompile]
    private void Start()
    {
        // Start spawning asteroids
        InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
    }
    [BurstCompile]
    private void SpawnAsteroid()
    {
        // Calculate a random position within the spawn radius
        Vector2 randomSpawnPosition = Random.insideUnitCircle.normalized * spawnRadius;

        // Instantiate the asteroid at the calculated position
        GameObject asteroid = Instantiate(asteroidPrefab, new Vector3(randomSpawnPosition.x, randomSpawnPosition.y, 0f), Quaternion.identity);
    }
}

