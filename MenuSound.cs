using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour {

	[FMODUnity.EventRef]
	public string bagtap;


	public static bool bagchack = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		if (bagchack == true) {

			FMODUnity.RuntimeManager.PlayOneShot (bagtap);


			bagchack = false;
		}
		
	}
}
