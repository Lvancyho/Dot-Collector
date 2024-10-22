using UnityEngine;

public class CoinDespawner : MonoBehaviour
{
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
