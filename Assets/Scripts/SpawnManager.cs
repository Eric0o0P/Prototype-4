using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, GenerateSpawnPos(), enemy.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPos()
    {
        float spawnposX = Random.Range(-9, 9);
        float spawnposZ = Random.Range(-9, 9);
        Vector3 randomPos = new Vector3 (spawnposX, 0, spawnposZ);

        return randomPos;
    }
}
