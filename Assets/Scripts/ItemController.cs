using UnityEngine;
using TMPro;

public class ItemController : MonoBehaviour
{
    public int ID;
    public int quantity;
    public bool Clicked = false;
    private MapMakerScript mapMaker;

    private void Start()
    {
        mapMaker = GameObject.FindGameObjectWithTag("MapMakerManager").GetComponent<MapMakerScript>();
    }
    public void ButtonClicked()
    {
        Clicked = true;
        quantity++;
        mapMaker.CurrentButtonPressed = ID;
    }
}
