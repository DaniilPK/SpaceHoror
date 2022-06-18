using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public CharacterController controller;

    public float speed;
    public float gravity = -9f;
    public float jumpHeight = 3f;
    
    // public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
  //  bool isGrounded;
    
    void Update()
    {

      //  isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (velocity.y < 0)
        {
            velocity.y = -2f;
        }



        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);


        

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        
    }

    /*  private void OnTriggerEnter(Collider other)
      {

          if (other.gameObject.tag == "Teleport")
          {
              transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
              Debug.Log("+");

              //transform.position = new Vector3(-27.98f, 1f, 0);
              //  transform.position += new Vector3(-27.98f, 1f, 0) * speed * Time.deltaTime;
              //  transform.Translate(-27.98f, 1f, 0);

          }
      }*/
}
