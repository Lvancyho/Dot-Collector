using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the circle will move

    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from the user
        float moveX = Input.GetAxis("Horizontal"); // Left/Right movement (A/D or Left/Right arrows)
        float moveY = Input.GetAxis("Vertical");   // Up/Down movement (W/S or Up/Down arrows)

        // Create a movement vector
        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed;

        // Move the circle
        rb.velocity = movement;
    }
}
