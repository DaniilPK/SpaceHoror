using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	private Animation anim;
	public float AnimSpeed = 1;
	private string _animName;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		_animName = anim.clip.name;
	}
	

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player")
		{
			anim [_animName].speed = 1 * AnimSpeed;
			anim [_animName].normalizedTime = 0;
			anim.Play ();
		}
	}
	void OnTriggerExit(Collider other){
		if(other.tag == "Player")
		{
			anim [_animName].speed = -1 * AnimSpeed;
			if (anim [_animName].normalizedTime > 0) {
				anim [_animName].normalizedTime = anim [_animName].normalizedTime;
			} else {
				anim [_animName].normalizedTime = 1;
			}
			anim.Play ();
		} 
	}
}
