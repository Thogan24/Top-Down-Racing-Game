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
    
    public bool recoil = false;
    public bool cooldown = false;
    public float cooldownTime;

    
    private void Start()
    {
        playerRB = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (cooldownTime <= 0.1 && cooldown)
        {
            cooldownTime += Time.deltaTime;
        }
        else
        {
            cooldown = false;
            cooldownTime = 0;
        }
        if (Input.GetMouseButtonDown(0) && cooldown == false)
        {            
            Shoot();
        }
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(prefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        
        
        Debug.Log(vector2);

        shootPosition = firePoint.up;
        
        vector2 = Vector2.one;
        recoil = true;
        
        this.gameObject.AddComponent<RecoilScript>();
        cooldown = true;
    }
}
