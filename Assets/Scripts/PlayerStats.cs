using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerStats : MonoBehaviour
{
    private Movement MovementScript;
    private BulletShoot BulletShootScript;
    public GameObject player;
    public TextMeshProUGUI StatsTextbox;
    

    void Start() {
        MovementScript = player.GetComponent<Movement>();
        BulletShootScript = player.GetComponent<BulletShoot>();
    }

    void Update()
    {
        StatsTextbox.text = "Speed: " + MovementScript.speedTracker.ToString("F2") +
        "<br>MovementSpeed: " + MovementScript.movementSpeed.ToString() +
        "<br>Angle: " + MovementScript.angle.ToString("F2") +
        "<br>BulletForce: " + BulletShootScript.bulletForce.ToString() +       
        "<br>Cooldown: " + BulletShootScript.cooldown.ToString();

    }
}
