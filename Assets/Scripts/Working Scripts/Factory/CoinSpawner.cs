using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public CoinPool coinPool; 
    public float spawnInterval = 2f; // Time between coin spawns
    public float spawnRangeX = 8f;
    public float spawnRangeY = 4f;

    // Randomly spawn a coin from the available types
    void Start()
    {
        InvokeRepeating("SpawnCoin", 0f, spawnInterval); // Start spawning coins
    }

    void SpawnCoin()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f)); // Random spawn position

        // Randomly choose a coin prefab from the pool
        int coinIndex = Random.Range(0, coinPool.coinPrefabs.Length);
        GameObject coinPrefab = coinPool.coinPrefabs[coinIndex]; // Get the coin prefab based on the random index

        GameObject coin = coinPool.GetCoin(coinPrefab); // Get the selected coin from the pool
        coin.transform.position = spawnPosition; // Set the coins spawn position
    }
}
