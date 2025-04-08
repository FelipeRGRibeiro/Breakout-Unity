using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public float speedIncrement = 0.5f;
    public float speedDecrement = 0.5f;
    public float minSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            speed += speedIncrement;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            speed = Mathf.Max(speed - speedDecrement, minSpeed); // Evitar velocidade negativa
        }
        AdjustBallDirection();
    }

    void AdjustBallDirection()
    {
        Vector2 currentDirection = rb.linearVelocity.normalized;
        rb.AddForce(currentDirection * speed, ForceMode2D.Impulse);
    }
}