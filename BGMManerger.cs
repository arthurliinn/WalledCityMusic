using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManerger : MonoBehaviour {

	public MusicPlayer MusicSystem;
	public MusicPlayerInside MusicSystem02;

	public static bool ToLastBuilding = false;
	public static bool ToOutside = true;

	public static int BGMswitch = 0;


	public static BGMManerger bgmMangInsitence;
	public static BGMManerger bgmMang()
	{
		return bgmMangInsitence;
	}





	// Use this for initialization
	void Start () {

		bgmMangInsitence = this;

	}
	
	// Update is called once per frame
	void Update () {
		//print (ToLastBuilding);

	/*if (ToLastBuilding == true) {
			
			MusicSystem.BGMStop ();
			ToOutside = false;
			ToLastBuilding = false;

		} 

		if (ToOutside == true) {

			ToLastBuilding = false;
			MusicSystem02.BGMFStop ();

		}
	*/

	}


	/*public void playInsideMusic(bool isplay)
	{
		if (isplay == true)
			MusicSystem02.BGMFStop ();
		else
			MusicSystem02.BGMFStart ();

	}


	public void playOutSideMusic(bool isplay)
	{
		if (isplay == true)
			MusicSystem.BGMStop ();
		else
			MusicSystem.BGMStart ();
	}*/


}
