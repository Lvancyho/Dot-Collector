using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveDistance = 5f; //speed for player

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); //left right
        float moveY = Input.GetAxis("Vertical");   //up down

        // Create a movement vector
        Vector2 movement = new Vector2(moveX, moveY).normalized * moveDistance;

        // Move the player
        rb.velocity = movement;
    }
}
