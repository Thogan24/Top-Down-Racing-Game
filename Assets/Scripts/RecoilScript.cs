using UnityEngine;

public class RecoilScript : MonoBehaviour
{
    public float time;
    public Vector2 shootPosition;

    void Start()
    {
        shootPosition = GetComponent<BulletShoot>().shootPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;

        if (time < 0.1)
        {
            GetComponent<Rigidbody2D>().AddForce(shootPosition * -GetComponent<BulletShoot>().recoilForce * time * 5);
            Debug.Log(shootPosition * -GetComponent<BulletShoot>().recoilForce * time * 5);
        }
        else if (time > 0.1 && time <= 1)
        {
            GetComponent<Rigidbody2D>().AddForce(shootPosition * -GetComponent<BulletShoot>().recoilForce * 5);
            Debug.Log(shootPosition * -GetComponent<BulletShoot>().recoilForce * 5);
        }
        else if (time > 1 && time < 2)
        {
            GetComponent<Rigidbody2D>().AddForce(shootPosition * -GetComponent<BulletShoot>().recoilForce * (2 - time) * 5);
            Debug.Log(shootPosition * -GetComponent<BulletShoot>().recoilForce * time * 5);
        }
        else
        {
            Destroy(this);
        }
        
    }
}
