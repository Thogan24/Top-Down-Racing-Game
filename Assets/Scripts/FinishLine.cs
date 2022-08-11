using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private GameManager GameManager;
    public GameObject GameManagerObject;
    public bool checkpointsNeedToBeCompleted = true;
    private void Start()
    {
        GameManager = GameManagerObject.GetComponent<GameManager>();
    }
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Player" && checkpointsNeedToBeCompleted == false)
        {
            Debug.Log("worked");
            GameManager.startTimer = false;
            Time.timeScale = 0.5f;
            Time.fixedDeltaTime = Time.timeScale * .02f;

        }
        else if (collider2D.tag == "Player" && checkpointsNeedToBeCompleted == true)
        {
            Debug.Log("Complete checkpoints first");

        }

    }
}
