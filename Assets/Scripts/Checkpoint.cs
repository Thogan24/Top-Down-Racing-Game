using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpoint;
    public bool checkpointCompleted;
    private FinishLine finishLineScript;

    void Start()
    {
        finishLineScript = GameObject.FindGameObjectWithTag("Player").GetComponent<FinishLine>();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && checkpointCompleted == false)
        {
            Debug.Log("AKLDJSHSAKDHJ");
            checkpointCompleted = true;
            finishLineScript.checkpointsNeedToBeCompleted = false;
        }

    }

}
