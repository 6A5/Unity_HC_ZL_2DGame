using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("第一關");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
