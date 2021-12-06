using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    ///////////// Левая дверь


    Animation anim;

    public GameObject Player;
    public bool isActive;


    void Awake()
    {
        anim = GetComponent<Animation>();
    }
    private void Update()
    {
        isActive = FController.isActive; // Сверяемся с FController
        Door();
    }
    public void Door()
    {
        if (isActive)
        {
            anim.Play("Left"); // запуск анимации
                               //  Debug.Log("activate Left");
            isActive = false;
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
