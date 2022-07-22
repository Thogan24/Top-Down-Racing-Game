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

            if (time < 100)
            {
                GetComponent<Rigidbody2D>().AddForce(shootPosition * -GetComponent<BulletShoot>().recoilForce);

            }
            else
            {               
                Destroy(this);
            }
        
    }
}
