using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextRand : MonoBehaviour {
public Text display;
string[] options = 
{"You are not of this screen", 
"You are all children of prefabs",
"I got this working",
"Reflect!"};


public int pressed = 0;

	// Use this for initialization
	void Start () {
		   System.Random random = new System.Random();
           string quote = options[Random.Range(0, options.Length)];
           display.text = quote;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space) && pressed == 0) 
		{
			NewRandom();
		}

		if (Input.GetKeyUp(KeyCode.Space)) {
			pressed = 0;
		}
	}		
	

	void NewRandom(){
		   pressed = 1;
           System.Random random = new System.Random();
           string quote = options[Random.Range(0, options.Length)];
           display.text = quote;
	}
}



				


		     
	