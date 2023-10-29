using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public HealthBehavior PlayerHP;
    public float InvFrame = 2f;
    private bool vulnerable = true;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (InvFrame >= 2f){
            vulnerable = true;
        } else {
            vulnerable = false;
            InvFrame += Time.deltaTime;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            rb2D.velocity = Vector2.zero;
        }
           if (collision.gameObject.CompareTag("Bat") || collision.gameObject.CompareTag("Zombie") )
        {
            if (vulnerable == true){
            PlayerHP.cur_health --;
            InvFrame = 0;
            }
        }

    }
}