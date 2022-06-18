using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	private bool inTrigger;
	public GameObject Player;
	private Elevator elevator;
	TextController textController;
	void Update()
	{
		if (inTrigger)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				Debug.Log("KeyON");
				textController.ANM();
				GameControll.elevatorkey = true;
				
			}
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == Player.tag)
		{
			inTrigger = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == Player.tag)
		{
			inTrigger = false;
		}
	}
}
