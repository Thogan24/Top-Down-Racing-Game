using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private GameManager GameManager;
    public GameObject GameManagerObject;
    private BulletShoot bulletShoot;
    public bool checkpointsNeedToBeCompleted = true;
    private void Start()
    {
        GameManager = GameManagerObject.GetComponent<GameManager>();
        bulletShoot = GameObject.FindGameObjectWithTag("Player").GetComponent<BulletShoot>();
    }
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Player" && checkpointsNeedToBeCompleted == false)
        {
            bulletShoot.canShoot = false;
            GameManager.EndGame();

        }
        else if (collider2D.tag == "Player" && checkpointsNeedToBeCompleted == true)
        {
            Debug.Log("Complete checkpoints first");

        }

    }
}
