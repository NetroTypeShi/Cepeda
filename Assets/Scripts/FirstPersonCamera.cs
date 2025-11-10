using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour 
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Transform characterTransform;
    [SerializeField] private Camera characterCamera;

    private Vector3 movement;
    private float xRotation;


    private void Update()
    {
        PlayerMovement();
        cameraMovement();
    }
    void PlayerMovement()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        movement = transform.right * movX + transform.up * movZ;
        characterController.SimpleMove(movement*movementSpeed);
    }
    
    void cameraMovement()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        xRotation -= mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        characterCamera.transform.localRotation = Quaternion.Euler(mouseX, 0, 0);
        characterTransform.Rotate(Vector3.up * mouseX);


    }
}
