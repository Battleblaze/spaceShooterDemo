using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] int asteroidAmount = 10;
    [SerializeField] GameObject asteroidPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnAsteriod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAsteriod()
    {
        Transform trans = null;
        trans.position = new Vector2(Random.Range(-9, 9), Random.Range(-5, 5));
        
        Instantiate(asteroidPrefab,transform.position = new Vector2(Random.Range(-9, 9), Random.Range(-5, 5)));
    }
}
