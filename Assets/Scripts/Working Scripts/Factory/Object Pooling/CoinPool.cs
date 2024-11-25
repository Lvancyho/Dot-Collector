using System.Collections.Generic;
using UnityEngine;

public class CoinPool : MonoBehaviour
{
    public GameObject[] coinPrefabs; // Array to hold different coin prefabs
    public int initialPoolSize = 10; // Initial pool size for each coin type

    private Dictionary<GameObject, Queue<GameObject>> coinPools = new Dictionary<GameObject, Queue<GameObject>>();

    void Start()
    {
        // Initialize pools for each coin type
        foreach (var coinPrefab in coinPrefabs)
        {
            Queue<GameObject> pool = new Queue<GameObject>();
            for (int i = 0; i < initialPoolSize; i++)
            {
                GameObject coin = Instantiate(coinPrefab);
                coin.SetActive(false);
                pool.Enqueue(coin);
            }
            coinPools[coinPrefab] = pool;
        }
    }

    // Get a coin from the pool
    public GameObject GetCoin(GameObject coinPrefab)
    {
        if (coinPools.ContainsKey(coinPrefab) && coinPools[coinPrefab].Count > 0)
        {
            GameObject coin = coinPools[coinPrefab].Dequeue();
            coin.SetActive(true); // Activate the coin
            return coin;
        }
        else
        {
            //create a new coin if no coins are available in the pool
            return Instantiate(coinPrefab);
        }
    }

    // Return a coin to the pool
    public void ReturnCoin(GameObject coin, GameObject coinPrefab)
    {
        coin.SetActive(false);
        coinPools[coinPrefab].Enqueue(coin);
    }
}
