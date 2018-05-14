using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerSound : MonoBehaviour {
	[FMODUnity.EventRef]
	public string aneGunFire;
	[FMODUnity.EventRef]
	public string aneReload;
	[FMODUnity.EventRef]
	public string bagopen;
	[FMODUnity.EventRef]
	public string bagtap;
	[FMODUnity.EventRef]
	public string punch;
	[FMODUnity.EventRef]
	public string kick;
	[FMODUnity.EventRef]
	public string cameraflash;
	[FMODUnity.EventRef]
	public string strike;
	[FMODUnity.EventRef]
	public string heart;

	FMOD.Studio.EventInstance heartbeatlow;

	public static bool Fire = false;
	public static bool Bagop = false;
	public static bool bagchack = false;
	public static bool backpunch = false;
	public static bool frontkick = false;
	public static bool Usecamera = false;
	public static bool bowlingStrike = false;
	public static bool heartbeat = false;
	public static bool heartbeatfast = false;

	// Use this for initialization
	void Start () {
		heartbeatlow =FMODUnity.RuntimeManager.CreateInstance (heart);
		heartbeatlow.start ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Fire == true) {
			FMODUnity.RuntimeManager.PlayOneShot (aneGunFire);
			FMODUnity.RuntimeManager.PlayOneShot (aneReload);

			Fire = false;
		}

		if (Bagop == true) {

			FMODUnity.RuntimeManager.PlayOneShot (bagopen);

			Bagop = false;
		}


		if (bagchack == true) {

			FMODUnity.RuntimeManager.PlayOneShot (bagtap);


			bagchack = false;
		}

		if (backpunch == true) {


			FMODUnity.RuntimeManager.PlayOneShot (punch);



			backpunch = false;


		}


		if (frontkick == true) {



			FMODUnity.RuntimeManager.PlayOneShot (kick);


			frontkick = false;


		}


		if (Usecamera == true) {



			FMODUnity.RuntimeManager.PlayOneShot (cameraflash);

			Usecamera = false;

		}

		if (bowlingStrike == true) {

			FMODUnity.RuntimeManager.PlayOneShot (strike);

			bowlingStrike = false;


		}


		if (heartbeat == true) {


			heartbeatbeging ();

			if (heartbeatfast == true) {


				maywilldie ();

			} else {

				maywillnotdie ();
			}


		} else {
			heal ();

		}


	}


	public void heartbeatbeging(){

		heartbeatlow.setParameterValue ("heart", 1f);



	}


	public void maywilldie(){

		heartbeatlow.setParameterValue ("close dead", 1f);


	}

	public void maywillnotdie(){

		heartbeatlow.setParameterValue ("close dead", 0f);
	}

	public void heal(){


		heartbeatlow.setParameterValue ("heart", 0f);
		heartbeatlow.setParameterValue ("close dead", 0f);
	}

}
