using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steeldoorsound : MonoBehaviour {

	public AudioSource steeldoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider Other){

		if (Other.tag == "Bullet") {steeldoor.Play ();}//被子彈打到


	}
}
