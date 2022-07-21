using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject prefab;
    public float bulletForce = 20f;
    

    public float force;
    public GameObject player;
    public Vector2 vector2;


    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(prefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        
        vector2.x *= firePoint.position.x;
        vector2.y *= firePoint.position.y;
        Debug.Log(vector2);
        player.GetComponent<Rigidbody2D>().AddForce(vector2 * bulletForce);

        vector2 = Vector2.one;
    }
}
