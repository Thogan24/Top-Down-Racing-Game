using UnityEngine;
using Cinemachine;

public class CameraZoomScript : MonoBehaviour
{
    public CinemachineVirtualCamera camera;
    public float zoomAmount; 
    void Update()
    {
        zoomAmount = camera.m_Lens.OrthographicSize;
        if (Input.GetAxis("Mouse ScrollWheel") != 0f && camera.m_Lens.OrthographicSize >= 5 && camera.m_Lens.OrthographicSize <= 20)
        {
            Debug.Log(camera.m_Lens.OrthographicSize);
            camera.m_Lens.OrthographicSize -= Input.GetAxis("Mouse ScrollWheel");
        }
        else if (camera.m_Lens.OrthographicSize < 5)
        {
            camera.m_Lens.OrthographicSize = 5f;
            //camera.m_Lens.OrthographicSize += Mathf.Abs(Input.GetAxis("Mouse ScrollWheel"));
        }
        else if (camera.m_Lens.OrthographicSize > 20)
        {
            camera.m_Lens.OrthographicSize = 20f;
            //camera.m_Lens.OrthographicSize += -Mathf.Abs(Input.GetAxis("Mouse ScrollWheel"));
        }
    }
}
