using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private GameManager GameManager;
    public GameObject GameManagerObject;
    private void Start()
    {
        GameManager = GameManagerObject.GetComponent<GameManager>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish Line")
        {
            Debug.Log("worked");
            GameManager.startTimer = false;

        }
        //Debug.Log("w");
    }
}
