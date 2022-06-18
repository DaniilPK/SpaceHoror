using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController82 : MonoBehaviour
{

    Animation anim;

    public GameObject Player;
    public bool isActive8;



    void Awake()
    {
        anim = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive8 = FController8.isActive8; // Сверяемся с FController
        Door82();
    }



    private void Door82()
    {
        if (isActive8)
        {
            anim.Play("Door82"); // запуск анимации
                                //   Debug.Log("activate Right");
            isActive8 = false;
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
