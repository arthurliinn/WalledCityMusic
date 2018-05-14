using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

	[FMODUnity.EventRef]
	public string code;

	public static bool codechange = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (codechange == true) {

			FMODUnity.RuntimeManager.PlayOneShot (code);

			codechange = false;


		}


	}
}
