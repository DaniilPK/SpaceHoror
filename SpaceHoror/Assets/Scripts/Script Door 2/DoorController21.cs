using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController21 : MonoBehaviour
{

    ///////////// ����� �����


    Animation animat;

    public GameObject Player;
    public bool isActive2;


    void Awake()
    {
        animat = GetComponent<Animation>();
    }
    private void Update()
    {
        isActive2 = FController2.isActive2; // ��������� � FController
        Door2();
    }
    public void Door2()
    {
        if (isActive2)
        {
            animat.Play("Left2"); // ������ ��������
                               //  Debug.Log("activate Left");
            isActive2 = false;
        }
    }

    /*  private void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.tag == "Player") {
            //  Debug.Log("Door Left");
              isActive = true;
          }
      }*/


}
