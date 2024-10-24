using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    // another singleton but also part of my factory
    public List<BaseCoin> coins = new List<BaseCoin>(); // Prefab for the coins and finds which prefabs to spew out. in my case its my two silver and gold coins
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

        //this is the singleton part
    }

    private void SpawnCoin()
    {
        int coinType = Random.Range(0, coins.Count);

        // spawns at a random position between x and -x
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(coins[coinType].coinPrefab, spawnPosition, Quaternion.identity);
    }
}
