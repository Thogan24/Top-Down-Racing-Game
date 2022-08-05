using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainUI : MonoBehaviour
{

    public bool GameIsPaused = false; 
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    public GameObject player;
    private PlayerStats ps;
    private void Start()
    {
        ps = player.GetComponent<PlayerStats>();
        ResumeGame();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (GameIsPaused)
            {
                ResumeGame(); 

            }
            else
            {
                PauseGame();

            }
        }
    }
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void PauseGame()
    {
        //Pause the game when this method is called. Unlocks the cursor from the screen
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Options()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
    }

    public void Back()
    {
        pauseMenuUI.SetActive(true);
        optionsMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }



}