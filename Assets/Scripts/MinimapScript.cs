using UnityEngine;
using UnityEngine.UI;

public class MinimapScript : MonoBehaviour
{

    public Transform player;
    public GameObject miniMapBorder;
    float h;
    float s;
    float v;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -15);
        

        Color.RGBToHSV(miniMapBorder.GetComponent<Image>().color, out h, out s, out v);
        miniMapBorder.GetComponent<Image>().color = Color.HSVToRGB(h + Time.deltaTime * .25f, s, v);
        

    }
}
 