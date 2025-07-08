using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Restart : MonoBehaviour
{
    public Button ConfirmButton;
    public GameObject ScoreBoard;
    public TextMeshProUGUI finalScore;
    private Player player;
    private void Start()
    {
        player = UnityEngine.Object.FindAnyObjectByType<Player>();
        ScoreBoard.SetActive(false);
        if (ConfirmButton != null)
        {
            // Adiciona um listener ao botão
            ConfirmButton.onClick.AddListener(Renew);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Morreu");
        finalScore.text += player.getScore().ToString();
        //ScoreBoard.SetActive(true);
        if (player.getLife() > 0)
        {
            player.decrementLife();

            //ScoreBoard.SetActive(false);
            Ball.DefinePosition();
            Player.DefinePosition();
        }
        else
        {
            ScoreBoard.SetActive(true);
        }
    }
    private void Renew()
    {
        EditorSceneManager.LoadScene("Menu");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif  
    }
}
