using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController3 : MonoBehaviour
{
   

    Animation animat;

    public GameObject Player;
    public bool isActive3;



    void Awake()
    {
        animat = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive3 = FController3.isActive3; // ��������� � FController
        Door3();
    }



    private void Door3()
    {
        if (isActive3)
        {
            animat.Play("Door3"); // ������ ��������
                                  //   Debug.Log("activate Right");
            isActive3 = false;
        }
    }

    /*  private void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.tag == "Player")
          {
            //  Debug.Log("Door Right");
              isActive = true;
          }
      }*/

}
