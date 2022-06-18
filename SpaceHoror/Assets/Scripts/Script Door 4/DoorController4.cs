using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController4 : MonoBehaviour
{
    Animation animat;

    public GameObject Player;
    public bool isActive4;



    void Awake()
    {
        animat = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive4 = FController4.isActive4; // Сверяемся с FController
        Door4();
    }



    private void Door4()
    {
        if (isActive4)
        {
            animat.Play("Door4"); // запуск анимации
                                  //   Debug.Log("activate Right");
            isActive4 = false;
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
