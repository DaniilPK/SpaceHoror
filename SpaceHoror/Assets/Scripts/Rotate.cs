using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
 
    private int sc;
   public GameObject Coin;
   public GameObject Player;
    void Update()
    {
        sc = GameController.Score;
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Player.gameObject.tag)
        {
            
            sc++;
            GameController.Score = sc;
            Debug.Log(sc);
            Destroy(Coin.gameObject);
        }
    }

}
