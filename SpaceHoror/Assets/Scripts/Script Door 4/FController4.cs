using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController4 : MonoBehaviour
{
    public static bool isActive4; // Статический,для передачи в другие скрипты
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            /////Debug.Log("FloorTEST");
            isActive4 = true;
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive4 = false;
    }
}
