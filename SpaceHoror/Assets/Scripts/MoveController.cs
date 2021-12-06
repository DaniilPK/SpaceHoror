using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    public CharacterController controller;

    public bool mov = false;
    public float speed;
    public float gravity = -9f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;


    void Update()
    {
       mov = GravityCube.MV;
      isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

      if ( velocity.y < 0)
        {
        velocity.y = -2f;
      }
        
       

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

       if (mov)
       {
            Debug.Log("+");
            velocity.y = Mathf.Sqrt(jumpHeight * -0.2f * gravity);
            
       }
      

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

   
}