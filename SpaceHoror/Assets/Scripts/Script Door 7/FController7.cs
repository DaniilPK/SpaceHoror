using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController7 : MonoBehaviour
{
    public static bool isActive7; // Статический,для передачи в другие скрипты
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Debug.Log("FloorTEST");
            isActive7 = true;
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive7 = false;
    }
}
