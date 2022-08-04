using UnityEngine;
using Cinemachine;

public class CameraZoomScript : MonoBehaviour
{
    public CinemachineVirtualCamera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0f) // forward
        {
            camera.m_Lens.OrthographicSize -= Input.GetAxis("Mouse ScrollWheel");
        }
    }
}
