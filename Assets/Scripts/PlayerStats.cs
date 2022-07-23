using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerStats : MonoBehaviour
{
    private Movement MovementScript;
    private BulletShoot BulletShootScript;
    public GameObject player;

    
    void Start() {
        MovementScript = player.GetComponent<Movement>();
        BulletShootScript = player.GetComponent<BulletShoot>();
    }

    void Update()
    {
        
    }
}
