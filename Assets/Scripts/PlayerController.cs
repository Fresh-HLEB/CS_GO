using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    private float speed = 5f;
    private float gravity = -9.81f;
    private float jumpHeight = 5f;
    //private float rotationSpeed=60;
    private Vector3 velocity;

    void Update()
    {
        float horizintal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //float mouseHorizontal=Input.GetAxis("Mouse X");
        //transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * mouseHorizontal);
        Vector3 move = transform.right * horizintal + transform.forward * vertical;
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.Space))
        {
            velocity.y = jumpHeight;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
}
