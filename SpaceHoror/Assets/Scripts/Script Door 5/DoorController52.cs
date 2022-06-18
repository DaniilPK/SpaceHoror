using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController52 : MonoBehaviour
{
    Animation animat;

    public GameObject Player;
    public bool isActive52;



    void Awake()
    {
        animat = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive52 = FController5.isActive5; // Сверяемся с FController
        Door52();
    }



    private void Door52()
    {
        if (isActive52)
        {
            animat.Play("Door52"); // запуск анимации
                                  //   Debug.Log("activate Right");
            isActive52 = false;
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
