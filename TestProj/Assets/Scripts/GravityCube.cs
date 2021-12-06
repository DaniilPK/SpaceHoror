using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCube : MonoBehaviour
{
    public static bool MV;

    private void OnTriggerStay(Collider other)
    {
        MV = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("-");
        MV = false;
    }
}
