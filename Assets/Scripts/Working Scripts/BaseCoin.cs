using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCoin : MonoBehaviour
{
    public int moneyValue;
    public string Type = "";
    public GameObject coinPrefab;

    public BaseCoin(int scoreValue, GameObject prefab)
    {
        moneyValue = scoreValue;
        coinPrefab = prefab;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player collided with this coin
        if (other.CompareTag("Player"))
        {
            // Find the CoinCollector component on the player
            CoinCollector collector = other.GetComponent<CoinCollector>();
            if (collector != null)
            {
                collector.CollectCoin(); // Call the method to collect the coin
            }
            Destroy(gameObject); // Destroy the coin
        }
    }
}