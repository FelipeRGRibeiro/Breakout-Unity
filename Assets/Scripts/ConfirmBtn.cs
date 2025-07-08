using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConfirmBtn : MonoBehaviour
{
    [SerializeField] private Button confirmButton;

    private void Start()
    {
        confirmButton.onClick.AddListener(() => SceneManager.LoadScene("Menu"));
    }
}
