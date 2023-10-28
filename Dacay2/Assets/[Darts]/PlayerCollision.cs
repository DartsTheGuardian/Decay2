using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Handle collision with the wall
            Debug.Log("Player collided with the wall.");
            // Add your custom code here to handle the collision
            rb2D.velocity = Vector2.zero;
        }
    }
}