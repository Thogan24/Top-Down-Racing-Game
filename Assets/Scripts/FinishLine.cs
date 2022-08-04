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
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish Line" && checkpointsNeedToBeCompleted == false)
        {
            Debug.Log("worked");
            GameManager.startTimer = false;

        }
        //Debug.Log("w");
    }
}
