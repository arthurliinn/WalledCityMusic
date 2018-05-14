using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
	[FMODUnity.EventRef]
	public string Music01 = "event:/Music/Area04";
	public string MusicF = "event:/Music/Final";

	FMOD.Studio.EventInstance BGM01;
	FMOD.Studio.EventInstance BGMF;
	private float vol=0.3f;


	public static bool bag = false;
	public static bool outside = true;

	// Use this for initialization
	void Start () {
		BGM01.setParameterValue ("dead", 0f);

		BGM01 = FMODUnity.RuntimeManager.CreateInstance (Music01);
		BGMF = FMODUnity.RuntimeManager.CreateInstance (MusicF);
		BGM01.start ();
		
	}
		
	// Update is called once per frame
	void Update () {

		if (Player.Dead == true) {
			//print ("DIE!!!!!!!");

			BGM01.setParameterValue ("dead", 1f);

			if (vol == 0) {

				BGM01.stop (FMOD.Studio.STOP_MODE.IMMEDIATE);
			}
		}
		if (bag == true) {

			BGM01.setParameterValue ("bag", 1f);
		} else if(bag == false){
			BGM01.setParameterValue ("bag", 0f);
		}

	}


	/*public void BGMStart()
	{
		BGM01.start ();
	}*/

	public void BGMStop(){

		BGM01.stop (FMOD.Studio.STOP_MODE.IMMEDIATE);
	}





	/*public void BGMStop(){
		print ("asd;kajsld;kajsd;alksjd");

		BGM01.stop (FMOD.Studio.STOP_MODE.IMMEDIATE);
		//BGMF.start ();
		}*/

	}

