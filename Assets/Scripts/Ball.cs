using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static float speed = 5f;
    public float maxSpeed = 50f;
    public static Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        DefinePosition();
    }

    void Update()
    {
        if(rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;

        }
        speed = rb.linearVelocity.magnitude;
    }

    public static void DefinePosition()
    {
        rb.transform.position = new Vector3(0, -3, 10);
        rb.linearVelocity = Vector2.down * speed;
    }
    

}