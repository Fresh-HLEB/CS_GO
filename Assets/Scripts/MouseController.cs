using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    //private float speedHorizontal = 9;
    //private float speedVertical = 9;
    //private float minVert = -45;
    //private float maxVert = 45;
    //private float rotationX;
    //private float rotationY;
    public float mouseSensitivity = 100f;
    public Transform player;
    private float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    void Update()
    {
        //rotationX -= Input.GetAxis("Mouse Y") * speedVertical;
        //rotationX = Mathf.Clamp(rotationY, minVert, maxVert);

        //float delta = Input.GetAxis("Mouse X") * speedHorizontal;
        //rotationY = transform.localEulerAngles.y + delta;

        //transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
