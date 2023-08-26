using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public GameObject sensorPrefab;
    int asteroidIndex;
    public Vector3 spawnPos;
    Vector3 sensorSpawnPos;
    public float spawnRange;
    public float startDelay;
    public float spawnInterval;
    public float sensorSpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAsteroid", startDelay, spawnInterval);
        InvokeRepeating("SpawnSensor", startDelay, sensorSpawnInterval);
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

    void SpawnSensor()
    {
        sensorSpawnPos = new Vector3(0, -1, 0);
        Instantiate(sensorPrefab, sensorSpawnPos, sensorPrefab.transform.rotation);
    }
}
