using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeSound : MonoBehaviour {




	int[] PassWordNumber = new int[4],PassWordAnswer = new int[4];
	int ChoosePassWordToggle,OpenNumber;
	bool [] CheckPassWordNumber = new bool[4];//判斷答案對不對


	bool CanInputH,CanInputV,CanInputHJ,CanInputVJ,Open,IsOpen;
	public static bool CanInputPassNumber = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");//左邊的箭頭
		float hj = Input.GetAxis ("HorizontalJoy");
		float vj = Input.GetAxis ("VerticalJoy");//左邊的箭頭
		if (h == 0)
			CanInputH = true;
		if (v == 0)
			CanInputV = true;//不能重複按著
		if (hj == 0)
			CanInputHJ = true;
		if (vj == 0)
			CanInputVJ = true;//不能重複按著
	
		if (CanInputPassNumber == true) {
			if (CanInputH == true) {
				if (h >= 1) {
					Box.codechange = true;
					CanInputH = false;
				} else if (h <= -1) {
					Box.codechange = true;
					CanInputH = false;
				}
			}
			

			if (CanInputV == true) {
				if (v >= 1) {
					Box.codechange = true;
					CanInputV = false;
				}//上
			else if (v <= -1) {
					Box.codechange = true;
					CanInputV = false;
				}//下
			}
			
				
			if (CanInputVJ == true)
			if (vj >= 1 || Input.GetKeyDown (KeyCode.W)) {
				Box.codechange = true;
				CanInputVJ = false;
			}//下
		else if (vj <= -1 || Input.GetKeyDown (KeyCode.S)) {
				Box.codechange = true;
				CanInputVJ = false;
			}//上
		}
	}



	void OnTriggerStay(Collider Other)
	{
		if (Other.tag == "Player") {
			
				
				if (Input.GetKeyDown (KeyCode.JoystickButton2)|| Input.GetKeyDown(KeyCode.E)){CanInputPassNumber = true;}
			else {CanInputPassNumber = false;}
	    }
	}


}

