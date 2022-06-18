using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController5 : MonoBehaviour
{
    Animation animat;

    public GameObject Player;
    public bool isActive5;



    void Awake()
    {
        animat = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive5 = FController5.isActive5; // Сверяемся с FController
        Door5();
    }



    private void Door5()
    {
        if (isActive5)
        {
            animat.Play("Door5"); // запуск анимации
                                  //   Debug.Log("activate Right");
          
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
