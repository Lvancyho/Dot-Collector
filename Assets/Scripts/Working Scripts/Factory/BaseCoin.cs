using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCoin : Subject
{
    public int moneyValue;
    public string Type = "";
    public GameObject coinPrefab;

    public BaseCoin(int scoreValue, GameObject prefab)
    {
        moneyValue = scoreValue;
        coinPrefab = prefab;

        //score and pref used
    }

    private void OnEnable()
    {
        if(GameManager.Instance)
        {
            //Attach(GameManager.Instance);
        }
    }

    private void OnDisable()
    {
        if(GameManager.Instance)
        {
            //Detach(GameManager.Instance);
        }
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

            GameManager.Instance.AddToScore(moneyValue);
            //NotifyObservers();
            Destroy(gameObject); // Destroy the coin
        }
    }
}