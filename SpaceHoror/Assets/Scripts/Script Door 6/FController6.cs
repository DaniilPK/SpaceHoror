using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController6 : MonoBehaviour
{
    public static bool isActive6; // �����������,��� �������� � ������ �������
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Debug.Log("FloorTEST");
            isActive6 = true;
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive6 = false;
    }
}
