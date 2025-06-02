using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Restart : MonoBehaviour
{
    public Button ConfirmButton;
    public GameObject ScoreBoard;
    public TextMeshProUGUI finalScore;
    private void Start()
    {
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
        finalScore.text += Player.score.ToString();
        ScoreBoard.SetActive(true);
    }
    private void Renew()
    {
        EditorSceneManager.LoadScene("Menu");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif  
    }
}
