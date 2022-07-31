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
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        
        Clicked = true;
        Instantiate(mapMaker.ItemImage[ID], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);
        
        quantity++;
        mapMaker.CurrentButtonPressed = ID;
    }
}
