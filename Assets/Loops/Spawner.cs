using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public int SpawnCount = 5;
    public float SpawnOffset = 1.5f;

    private void Start()
    {
        if (SpawnPrefab != null)
        {
            SpawnEnemies();
        }
        else
        {
            Debug.LogError("ERROR! Prefab is missing!");
        }
    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < SpawnCount; i++)
        {
            float xPos = i * SpawnOffset;
            Vector3 spawnPos = new Vector3(xPos, 0f, 0f);
            Instantiate(SpawnPrefab, spawnPos, Quaternion.identity);
        }
    }
}
