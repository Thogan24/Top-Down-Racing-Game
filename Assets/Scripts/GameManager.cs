using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TimerTextbox;
    public GameObject CongratulationsTextbox;
    public GameObject TimerObject;
    public float timer;
    public bool startTimer;
    public bool showTimer;
    public GameObject finishLine;
    bool gameHasEnded;
    //public TextMeshProUGUI Timer;

    void Update()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;
            TimerTextbox.text = "Time: " + timer.ToString("F3");
        }

        if (Input.GetKeyDown(KeyCode.T) == true)
        {


            if (showTimer == false)
            {               
                showTimer = true;
                TimerObject.SetActive(true);
            }
            else
            {
                showTimer = false;
                TimerObject.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) == true) //&& Input.GetKeyDown(KeyCode.R) == true
        {
            Debug.Log("Bruh");
            Restart();
        }
    }

    public void EndGame()
    {
        gameHasEnded = true;
        Debug.Log("worked");
        startTimer = false;
        Time.timeScale = 0.5f;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        CongratulationsTextbox.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
