using UnityEngine;

public class CameraController
{
    [SerializeField]
    private float sensibility;

    private Vector2 mouseInput;

    private float pitch;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, mouseInput.x * sensibility* Time.deltaTime); transform.localEulerAngleshng

        pitch -= mouseInput.y*sensibility* Time.deltaTime;
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        transform.localEulerAngles = new Vector3(pitch, transform.localEulerAngles.y, 0f);
    }

    private void OnMouseMove(Input.Action.CallbackContext)
    {

    }

}
