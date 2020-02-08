using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[]  spawnPoints;
    public float        firstSpawnTime = 4.0f;
    public float        nextSpawnTime = 2.0f;
    public GameObject[] enemyPrefab;

    float   timer;

    void Start()
    {
        timer = firstSpawnTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0f)
        {
            timer = nextSpawnTime;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        int spawnPoint = Random.Range(0, spawnPoints.Length);
        int enemy = Random.Range(0, enemyPrefab.Length);
        Instantiate(enemyPrefab[enemy], spawnPoints[spawnPoint].position, spawnPoints[spawnPoint].rotation);
    }
}
