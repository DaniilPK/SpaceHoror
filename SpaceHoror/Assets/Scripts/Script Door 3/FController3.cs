using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController3 : MonoBehaviour
{
    public static bool isActive3; // Статический,для передачи в другие скрипты
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            /////Debug.Log("FloorTEST");
            isActive3 = true;
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive3 = false;
    }
}
