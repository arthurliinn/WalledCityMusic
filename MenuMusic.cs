using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour {
	[FMODUnity.EventRef]
	public string Musicmenu = "event:/Music/MenuBGM";
	FMOD.Studio.EventInstance BGM;


	// Use this for initialization
	void Start () {
		BGM = FMODUnity.RuntimeManager.CreateInstance (Musicmenu);
		BGM.start();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void BGMstop(){

		BGM.stop (FMOD.Studio.STOP_MODE.IMMEDIATE);

	}
}
