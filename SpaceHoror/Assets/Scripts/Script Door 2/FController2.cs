using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController2 : MonoBehaviour
{
    public static bool isActive2; // �����������,��� �������� � ������ �������
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          /////Debug.Log("FloorTEST");
            isActive2 = true; 
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive2 = false;
    }
}
