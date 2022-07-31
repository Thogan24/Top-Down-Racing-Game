using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectScript : MonoBehaviour
{
    public int ID;
    private MapMakerScript mapMaker;
    void Start()
    {
        mapMaker = GameObject.FindGameObjectWithTag("MapMakerManager").GetComponent<MapMakerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(this.gameObject);
            mapMaker.ItemButtons[ID].quantity--;
        }
    }
}
