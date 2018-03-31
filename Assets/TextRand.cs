﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextRand : MonoBehaviour {
public Text display;
string[] options = 
{"You are a chosen child of Prefab",
"You are not of this screen",
"This Scene is your right",
"Variables are counting on you",
"Player one started it",};


public int pressed = 0;

	// Use this for initialization
	void Start () {
		   System.Random random = new System.Random();
           string quote = options[Random.Range(0, options.Length)];
           display.text = quote;
	}
	
	// Update is called once per frame
	void Update () {
		
    /* if (Input.GetKey(KeyCode.Return)) 
			{
				if(GameObject.Find("byebye") == null) {
			    display.text = "Player 2 wins"; }
			} 

		if(GameObject.Find("byebye") != null){ */

			if (Input.GetKey(KeyCode.Return)) {
			pressed = 0; }


			 if (Input.GetKeyDown(KeyCode.Return) && pressed == 0){
				NewRandom();
		         }
		
		//}
	}		
	

	void NewRandom(){
		   pressed = 1;
           System.Random random = new System.Random();
           string quote = options[Random.Range(0, options.Length)];
           display.text = quote;
	}

}



				


		     
	