using UnityEngine;

public class MinimapScript : MonoBehaviour
{

    public Transform player;

    private void LateUpdate()
    {
        Vector2 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
