﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insidemusicctrl : MonoBehaviour {

	public MusicPlayerInside musicinside;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}


	void OnTriggerStay(Collider other) 
	{
		if (other.tag == "Player") {if (Input.GetKey (KeyCode.JoystickButton2) || Input.GetKey (KeyCode.E)){musicinside.BGMFStop ();}}
	}
}