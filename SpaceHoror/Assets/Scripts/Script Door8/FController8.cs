using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController8 : MonoBehaviour
{
    public static bool isActive8; // Статический,для передачи в другие скрипты
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Debug.Log("FloorTEST");
            isActive8 = true;
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive8 = false;
    }
}
