using UnityEngine;

public class LookController : MonoBehaviour
{
    public Camera cam;
    public float mouseSensitivity = 100f;
    private float rotationY = 0f;
    private float rotationX = 0f;
    private float mouseX = 0f;
    private float mouseY = 0f;

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(0f, rotationY, 0f);
        cam.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}
