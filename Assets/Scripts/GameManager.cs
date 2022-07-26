using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TimerTextbox;
    public float timer;
    public bool startTimer;

    void Update()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;
            TimerTextbox.text = "Time: " + timer.ToString("F3");
        }
    }
}
