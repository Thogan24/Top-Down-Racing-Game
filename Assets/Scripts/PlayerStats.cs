using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerStats : MonoBehaviour
{
    public bool showStats;

    public GameObject statsCanvas;
    private Movement MovementScript;
    private BulletShoot BulletShootScript;
    public GameObject player;
    public TextMeshProUGUI StatsTextbox;

    private GameManager GameManager;
    public GameObject GameManagerObject;

    void Start() {
        GameManager = GameManagerObject.GetComponent<GameManager>();
        showStats = false;
        statsCanvas.SetActive(false);
        MovementScript = player.GetComponent<Movement>();
        BulletShootScript = player.GetComponent<BulletShoot>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote) == true)
        {

            
            if (showStats == false)
            {
                statsCanvas.SetActive(true);
                showStats = true;
            }
            else
            {
                statsCanvas.SetActive(false);
                showStats = false;
            }
        }
        StatsTextbox.text = "X Speed: " + MovementScript.speedTrackerx.ToString("F2") +
        "<br>Y Speed: " + MovementScript.speedTrackery.ToString("F2") +
        "<br>MovementSpeed: " + MovementScript.movementSpeed.ToString() +
        "<br>Angle: " + MovementScript.angle.ToString("F2") +
        "<br>BulletForce: " + BulletShootScript.bulletForce.ToString() +       
        "<br>Cooldown: " + BulletShootScript.cooldown.ToString() +
        "<br>Timer: " + GameManager.startTimer.ToString() +
        "<br>Coordinates: <br>" + MovementScript.playerTransform.position.x + ", " + MovementScript.playerTransform.position.y;


    }
}
