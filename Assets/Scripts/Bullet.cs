using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
