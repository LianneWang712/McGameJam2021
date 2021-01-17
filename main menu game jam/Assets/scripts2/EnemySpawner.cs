using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Array of types of enemies to spawn
    public GameObject[] enemyPrefabs;
    // Range of where to spawn enemies
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    // How frequently to spawn enemies
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Repeately call the spawner method on specified intervals
        InvokeRepeating("SpawnRandomEnemy", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        // randomly generate spawn position and enemy index
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int index = Random.Range(0, enemyPrefabs.Length);

        // create the enemy based off of randomized parameters
        Instantiate(enemyPrefabs[index], spawnPos, enemyPrefabs[index].transform.rotation);
    }
}
