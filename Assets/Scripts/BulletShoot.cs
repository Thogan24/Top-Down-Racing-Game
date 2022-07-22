using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject prefab;
    public float bulletForce = 20f;
    

    public float force;
    public GameObject player;
    public Vector2 vector2;
    public Vector2 shootPosition;
    public float recoilForce;
    public Rigidbody2D playerRB;
    public float time = 0;
    public bool recoil = false;
    
    private void Start()
    {
        playerRB = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            Shoot();
            
        }
        if (recoil)
        {
            time += Time.deltaTime;

            if (time < 1)
            {
                player.GetComponent<Rigidbody2D>().AddForce(shootPosition * -recoilForce);

            }
            else
            {
                time = 0;
                recoil = false;
            }
        }

        //if (Input.GetMouseButton(0))
        //{
        //    player.GetComponent<Rigidbody2D>().AddForceAtPosition(firePoint.up * -recoilForce, player.transform.position);
        //}
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(prefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        
        //vector2.x *= firePoint.position.x;
        //vector2.y *= firePoint.position.y;
        Debug.Log(vector2);

        shootPosition = firePoint.up;
        //player.GetComponent<Rigidbody2D>().MovePosition(playerRB.position * -recoilForce);
        vector2 = Vector2.one;
        recoil = true;
        time = 0;
    }
}
