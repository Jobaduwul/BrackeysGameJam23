using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    int asteroidIndex;
    public Vector3 spawnPos;
    public float spawnRange;
    public float startDelay;
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAsteroid", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAsteroid()
    {
        asteroidIndex = Random.Range(0, asteroidPrefabs.Length);
        spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), -1, 1.6f);
        Instantiate(asteroidPrefabs[asteroidIndex], spawnPos, asteroidPrefabs[asteroidIndex].transform.rotation);
    }
}
