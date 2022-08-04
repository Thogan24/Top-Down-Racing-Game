using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpoint;
    public bool checkpointCompleted;

    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && checkpointCompleted == false)
        {
            Debug.Log("AKLDJSHSAKDHJ");
            checkpointCompleted = true;
        }

    }

}
