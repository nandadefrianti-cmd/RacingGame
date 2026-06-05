using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public float mouseSensitivity = 100f;

    void Start()
    {
        // Mengunci kursor di tengah agar tidak mengganggu
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // 1. Pergerakan Maju/Mundur/Kiri/Kanan
        float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveSide = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(moveSide, 0, moveForward);

        // 2. Rotasi dengan Mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);
    }
}