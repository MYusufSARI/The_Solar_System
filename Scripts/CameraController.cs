using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        cameras[currentCameraIndex].gameObject.SetActive(true);
    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Tab))
        {
            cameras[currentCameraIndex].gameObject.SetActive(false);

            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

            cameras[currentCameraIndex].gameObject.SetActive(true);
        }
    }
}
