using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController22 : MonoBehaviour
{
    ///////////// Правая дверь
    



    Animation animat;

    public GameObject Player;
    public bool isActive2;



    void Awake()
    {
        animat = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive2 = FController2.isActive2; // Сверяемся с FController
        Door2();
    }



    private void Door2()
    {
        if (isActive2)
        {
            animat.Play("Right2"); // запуск анимации
         //   Debug.Log("activate Right");
            isActive2 = false; 
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
