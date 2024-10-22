using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab for the yellow coin
    public float spawnInterval = 2f; // Time interval between spawns
    public float spawnRangeX = 8f;    // Range for spawning on the X-axis
    public float spawnRangeY = 4f;    // Range for spawning on the Y-axis

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 0f, spawnInterval); // Start spawning circles
    }

    private void SpawnCoin()
    {
        // Generate a random position within the specified range
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
        // Instantiate the yellow circle at the random position
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
