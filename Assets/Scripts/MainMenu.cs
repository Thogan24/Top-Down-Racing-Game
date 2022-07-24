using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject StartGameButton;
    public GameObject MapMakerButton;
    public GameObject QuitButton;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartMapMaker()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void QuitGame()
    {

        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    

}
