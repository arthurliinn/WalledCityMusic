using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerInside : MonoBehaviour {
	[FMODUnity.EventRef]

	public string MusicF = "event:/Music/Final";

	//FMOD.Studio.EventInstance BGM01;
	FMOD.Studio.EventInstance BGMF;
	//private float vol=0.3f;

	// Use this for initialization
	void Start () {
		//BGM01.setParameterValue ("dead", 0f);

	//	BGM01 = FMODUnity.RuntimeManager.CreateInstance (Music01);
		BGMF = FMODUnity.RuntimeManager.CreateInstance (MusicF);
		BGMF.start ();

	}

/*	public void BGMFStart()
	{	
		BGMF.start ();
	}*/

	public void BGMFStop(){

		BGMF.stop (FMOD.Studio.STOP_MODE.IMMEDIATE);
	}








	// Update is called once per frame
	void Update () {


	}




}
