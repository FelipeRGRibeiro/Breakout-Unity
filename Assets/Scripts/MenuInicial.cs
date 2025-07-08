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
        // Verifica se o bot�o foi atribu�do no Inspector
        if (newGame != null)
        {
            // Adiciona um listener ao bot�o
            newGame.onClick.AddListener(mainScene);
        }
        if (exit != null)
        {
            // Adiciona um listener ao bot�o
            exit.onClick.AddListener(quit);
        }
    }
    void mainScene()
    {
        EditorSceneManager.LoadScene("MainGame");
        // Coloque aqui o que deseja que aconte�a quando o bot�o for clicado
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
