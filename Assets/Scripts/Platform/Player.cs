using UnityEngine;

public class Player : MonoBehaviour
{
    public float unitSpeed = 12f;
    public Rigidbody2D rb;
    public static int score = 0;
    void Start()
    {
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal") * unitSpeed *  Time.deltaTime;

        float newPosition = Mathf.Clamp(transform.position.x + movement, -2.3f, 2.3f);

        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }


}
