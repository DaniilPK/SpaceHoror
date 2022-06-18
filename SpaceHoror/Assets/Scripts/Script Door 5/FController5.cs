using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController5 : MonoBehaviour
{
    public static bool isActive5; // Статический,для передачи в другие скрипты
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           // Debug.Log("FloorTEST");
            isActive5 = true;
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive5 = false;
    }
}
