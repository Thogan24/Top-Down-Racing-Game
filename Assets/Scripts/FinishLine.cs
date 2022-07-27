using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish Line")
        {
            Debug.Log("worksed");
        }
        //Debug.Log("w");
    }
}
