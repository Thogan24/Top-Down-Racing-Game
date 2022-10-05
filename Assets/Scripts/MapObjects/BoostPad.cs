using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPad : MonoBehaviour
{
    public GameObject player;
    public float time;
    public Vector2 direction;// Not shoot position, but the direction they are currently moving in
    public float boostPadForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        direction = player.transform.position;
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Player")
        {
            addBoostForce(); // Need to figure out a way for it to stay after (it is currently only doing it when inside then it stops the time
        }
        
    }

    void addBoostForce()
    {
        time += Time.deltaTime;

        if (time < 0.1)
        {
            player.GetComponent<Rigidbody2D>().AddForce(direction * boostPadForce * time * 100);
            //Debug.Log(shootPosition * -GetComponent<BulletShoot>().recoilForce * time * 5);
        }
        else if (time > 0.1 && time <= 0.7)
        {
            player.GetComponent<Rigidbody2D>().AddForce(direction * boostPadForce * 100);
            //Debug.Log(shootPosition * -GetComponent<BulletShoot>().recoilForce * 5);
        }
        else if (time > 0.7 && time < 1.5)
        {
            player.GetComponent<Rigidbody2D>().AddForce(direction * boostPadForce * (1.5f - time) * 100);
            //Debug.Log(shootPosition * -GetComponent<BulletShoot>().recoilForce * time * 5);
        }
        else
        {
            time = 0;
        }
    }
}
