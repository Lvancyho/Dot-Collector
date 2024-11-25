using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinPool coinPool; // coinpool script
    public GameObject coinPrefab; //coin prefab

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinPool.ReturnCoin(gameObject, coinPrefab); // Return this coin to the pool
        }
    }
}
