using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public Button newGame;
    public Button exit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Verifica se o botão foi atribuído no Inspector
        if (newGame != null)
        {
            // Adiciona um listener ao botão
            newGame.onClick.AddListener(mainScene);
        }
        if (exit != null)
        {
            // Adiciona um listener ao botão
            exit.onClick.AddListener(quit);
        }
    }
    void mainScene()
    {
        EditorSceneManager.LoadScene("MainGame");
        // Coloque aqui o que deseja que aconteça quando o botão for clicado
    }
    
    void quit()
    {
        Application.Quit();
#if UNITY_EDITOR
        // Para parar o jogo dentro do editor
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
