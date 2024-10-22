using UnityEngine;

public class CoinDespawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player collided with this circle
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); // Destroy the yellow circle
        }
    }
}
