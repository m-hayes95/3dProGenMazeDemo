using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera look code from Brackeys https://www.youtube.com/watch?v=_QajrabyTJc

public class CameraLookAt : MonoBehaviour
{
    public float mouseSensitivity = 200f;
    private float xRotation = 0f;

    public Transform player;

    private void Start()
    {
        // Lock cursor into screen
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Mouse Look at inputs
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Add Y rotation around the X axis (+ Inverts the Y camera).
        xRotation -= mouseY;
        // Clamp the rotation so player cant look behind them.
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // Rotate player around the X axis.
        player.Rotate(Vector3.up * mouseX);
        
    }
}

