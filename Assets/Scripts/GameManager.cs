using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TimerTextbox;
    public GameObject TimerObject;
    public float timer;
    public bool startTimer;
    public bool showTimer;
    public GameObject finishLine;
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
    }
}
