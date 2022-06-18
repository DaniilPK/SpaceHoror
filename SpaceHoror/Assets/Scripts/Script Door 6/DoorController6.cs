using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController6 : MonoBehaviour
{
  
    Animation anim;

    public GameObject Player;
    public bool isActive6;



    void Awake()
    {
        anim = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive6 = FController6.isActive6; // Сверяемся с FController
        Door6();
    }



    public void Door6()
    {
        if (isActive6)
        {
            anim.Play("Door6"); // запуск анимации
                                //   Debug.Log("activate Right");
            isActive6 = false;
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
