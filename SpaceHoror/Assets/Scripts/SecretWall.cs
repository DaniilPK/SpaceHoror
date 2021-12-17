using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWall : MonoBehaviour
{
    void Update()
    {
        float Sc = GameController.Score;
        if (Sc == 6) 
        {
        Destroy(gameObject);
        }
    }
}
