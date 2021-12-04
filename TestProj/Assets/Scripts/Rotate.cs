using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   public GameObject Coin;
    void Update()
    {
       transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
             Destroy(Coin);
        }
    }

}
