using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TimerTextbox;
    public float timer;

    void Update()
    {
        timer += Time.deltaTime;
        TimerTextbox.text = "Time: " + timer.ToString("F3");
    }
}
