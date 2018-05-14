using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour {

	[FMODUnity.EventRef]

	public string inputsound;
	public static bool playermoving;
	public static bool run =false;
	public static bool sneaking = false;
	public float walkingspeed;




	void Update(){









		/*
		if (Input.GetAxis ("Vertical") >= 0.01f || Input.GetAxis ("Horizontal") >= 0.01f || Input.GetAxis ("Vertical") <= -0.01f || Input.GetAxis ("Horizontal") <= -0.01f) {
		
			playermoving = true;
		
		
		
		} else if (Input.GetAxis ("Vertical") == 0 || Input.GetAxis ("Horizontal") == 0) {


			playermoving = false;
		}



			if (playermoving == true) {
				if (Input.GetKey (KeyCode.JoystickButton5) || (Input.GetKey (KeyCode.JoystickButton10)) || Input.GetKey (KeyCode.LeftShift)) {


					walkingspeed = 0.3f;
				} else {

					walkingspeed = 0.5f;


				}
			}*/









//		print (playermoving);


	}




	void CallFootsteps()
		{

		//print ("asdasdasdasdasdas");
		if (playermoving == true && run == false && sneaking == false) {
			//print ("walk");
			FMODUnity.RuntimeManager.PlayOneShot (inputsound);
			//playermoving = false;
		}





		}





	void Start(){

		InvokeRepeating ("CallFootsteps", 0f, walkingspeed);


	}





	void OnDisable(){

		playermoving = false;

	}


	}









