using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject powerUpPrefab;
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
       SpawnEnemy(waveNumber);
       Instantiate(powerUpPrefab, GenerateSpawnPos(), powerUpPrefab.transform.rotation);

    }

    void SpawnEnemy(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemy, GenerateSpawnPos(), powerUpPrefab.transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemy(waveNumber);
            Instantiate(powerUpPrefab, GenerateSpawnPos(), enemy.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPos()
    {
        float spawnposX = Random.Range(-9, 9);
        float spawnposZ = Random.Range(-9, 9);
        Vector3 randomPos = new Vector3 (spawnposX, 0, spawnposZ);

        return randomPos;
    }
}
