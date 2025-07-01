using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float unitSpeed = 12f;
    public Rigidbody2D rb;
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public static int life = 2;
    public TextMeshProUGUI lifeText;
    public static int stage = 1;
    public TextMeshProUGUI stageText;
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
        scoreText.text = score.ToString();
        lifeText.text = life.ToString();
        stageText.text = stage.ToString();
    }


}
