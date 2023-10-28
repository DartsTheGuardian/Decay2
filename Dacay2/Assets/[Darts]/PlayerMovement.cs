using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Player movement speed

    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalMovement, verticalMovement) * speed * Time.deltaTime;
        rb2D.MovePosition(rb2D.position + movement);
    }
}



