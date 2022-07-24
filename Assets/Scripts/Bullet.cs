using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject hitEffectBullet;
    public float time;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "player" && collision.gameObject.tag != "Bullet")
        {
            Debug.Log(collision.gameObject.tag);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log(collision.gameObject.tag);
            GameObject effect = Instantiate(hitEffectBullet, transform.position, Quaternion.identity);
            Destroy(effect, 5f);
            Destroy(gameObject);
        }
        Debug.Log("Bruh");
    }
    private void Update()
    {
        time = time + Time.deltaTime * 1;
        if (time > 5)
        {
            //Destroy the object
        }
    }
}
