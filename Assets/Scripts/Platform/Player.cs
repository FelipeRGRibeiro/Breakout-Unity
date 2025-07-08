using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float unitSpeed = 12f;
    private Rigidbody2D rb;
    private int score = 0;
    public TextMeshProUGUI scoreText;
    private int life = 2;
    public TextMeshProUGUI lifeText;
    private int stage = 1;
    public TextMeshProUGUI stageText;
    public static Player player { get; private set; }
    private void Awake()
    {
        if (player == null)
            player = this;
        else
            Destroy(gameObject);

        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
            Debug.LogError("Rigidbody2D not found on Player!");

    }
    public void decrementLife()
    {
        player.life--;
    }
    public int getLife()
    {
        return player.life; 
    }
    public void setScore(int Score)
    {
        player.score = Score;
    }
    public void incrementScore()
    {
        player.score++;
    }
    public int getScore()
    {
        return player.score;
    }
    public void incrementStage()
    {
        player.stage++;
    }
    public int getStage()
    {
        return player.stage;
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
    public static void DefinePosition()
    {
        if (player.rb != null)
            player.rb.transform.position = new Vector3(0, -4.3f, 10);
    }

}
