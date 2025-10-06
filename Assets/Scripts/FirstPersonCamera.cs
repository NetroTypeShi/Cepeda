using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour 
{
    [SerializeField] float sensibility;
    float mouseX;
    float mouseY;
    float xRotation;
    public Transform playerTransform;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensibility * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse X") * sensibility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, -90f); 

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * mouseX);

    }
}
