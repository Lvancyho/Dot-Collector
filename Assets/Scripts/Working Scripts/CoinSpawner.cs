using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    // Our singleton
    public List<BaseCoin> coins = new List<BaseCoin>(); // Prefab for the yellow coin
    public float spawnInterval = 2f; // Time interval between spawns
    public float spawnRangeX = 8f;    // Range for spawning on the X-axis
    public float spawnRangeY = 4f;    // Range for spawning on the Y-axis

    public CoinSpawner instance;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 0f, spawnInterval); // Start spawning coins

        if (instance != this && instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }

    private void SpawnCoin()
    {
        int coinType = Random.Range(0, coins.Count);

        // Generate a random position within the specified range
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
        // Instantiate the yellow coins at the random position
        Instantiate(coins[coinType].coinPrefab, spawnPosition, Quaternion.identity);
    }
}
