using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("PondMap");
    }
    public void QuitGame()
    {
        Debug.Log("Quit clicked");
        Application.Quit();
    }
}
