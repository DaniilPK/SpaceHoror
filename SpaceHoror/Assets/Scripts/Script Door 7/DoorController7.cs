using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController7 : MonoBehaviour
{

    Animation anim;

    public GameObject Player;
    public bool isActive7;



    void Awake()
    {
        anim = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive7 = FController7.isActive7; // ��������� � FController
        Door6();
    }



    public void Door6()
    {
        if (isActive7)
        {
            anim.Play("Door7"); // ������ ��������
                                //   Debug.Log("activate Right");
            isActive7 = false;
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
