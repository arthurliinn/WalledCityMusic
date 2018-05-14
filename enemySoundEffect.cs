using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySoundEffect : MonoBehaviour {
	[FMODUnity.EventRef]
	public string GunShot;
	[FMODUnity.EventRef]
	public string KnifeCut;

	public AudioSource enemyfoot;
	public AudioSource enemyfound01;
	public AudioSource enemyfound02;
	public AudioSource enemyattack01;
	public AudioSource enemyattack02;
	public AudioSource enemyfeelstrange01;
	public AudioSource enemyfeelstrange02; 

	Transform player;
	public static bool Gunattack=false ;
	public static bool Knifeattack=false;
	public static bool run;
	public static bool playerdie;
	public float walkingspeed;
	public static int attacknumber;
	public  int foundnumber;
	public  int strangenumber;
	public bool enemywantattack = false;
	public  bool enemyfirstfound = false;
	public bool enemystrange = false;
	// Use this for initialization
	void Start () {
	//	InvokeRepeating ("CallFootsteps", 0f, walkingspeed);
	}

	// Update is called once per frame
	void Update ()
	{
		
		if (Gunattack == true) {
			FMODUnity.RuntimeManager.PlayOneShot (GunShot);
			Gunattack = false;
		}

		if (Knifeattack == true) {
			FMODUnity.RuntimeManager.PlayOneShot (KnifeCut);
			Knifeattack = false;
		}

		if (run == true && enemyfoot.isPlaying == false && playerdie == false && Knifeattack == false) {
			enemyfoot.Play ();
		}

		if (enemywantattack == true) {
			
			attacknumber = Random.Range (0, 3);
			print (attacknumber);
			if (attacknumber == 0) {
				enemyattack01.Play ();
				print ("hit");
				enemywantattack = false;

			}
			if (attacknumber == 1) {
				enemyattack02.Play ();
				print ("hit2");
				enemywantattack = false;
			}
		}

		if (enemyfirstfound == true) {
			foundnumber = Random.Range (0, 3);
			if (foundnumber == 0) {
				enemyfound01.Play ();
				enemyfirstfound = false;
			}
			if (foundnumber == 1) {
				enemyfound02.Play ();
				enemyfirstfound = false;
			}
		}


		if (enemystrange == true) {
			strangenumber = Random.Range (0, 3);
			if (strangenumber == 0) {
				enemyfeelstrange01.Play ();
				enemystrange = false;
			}
			if (foundnumber == 1) {
				enemyfeelstrange02.Play ();
				enemystrange = false;
			}
		}

	}


	/*public static void enemywanttoattack(){

		attacknumber = Random.Range (0, 3);
		print (attacknumber);
		if (attacknumber == 0) {
			enemyattack01.Play ();
			print ("hit");
			enemywantattack = false;

		}
		if (attacknumber == 1) {
			enemyattack02.Play ();
			print ("hit2");
			enemywantattack = false;
		}


	}*/
}