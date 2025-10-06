using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour 
{
    [SerializeField] float sensibility;
    float mouseX;
    float mouseY;
    public Transform playerTransform;

    void Start()
    {
        
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensibility * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse X") * sensibility * Time.deltaTime;

    }
}
