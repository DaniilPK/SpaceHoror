using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

	private NavMeshAgent agent;
	public GameObject Player;
	void Start()
	{
	
		agent = GetComponent<NavMeshAgent>();
	}
	void Update()
	{
		agent.SetDestination(Player.transform.position);
	}
}
