using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextRand : MonoBehaviour {
public Text display;
public Camera Camera1; 
string[] options = 
{"\n*Cough cough*",
"\n...",
"...You are a chosen child of Prefab...",
" ...You are not of this screen...",
"...This Scene is your right...",
"\n*wheeze*",
"...Variables are counting on you...",
" ...Player one started it...",};

//
//public int pressed = 0;

	// Use this for initialization
	void Start () {
		   System.Random random = new System.Random();
           string quote = options[Random.Range(0, options.Length)];
           display.text = quote;
	}
	
	// Update is called once per frame
	void Update () {
		//    Ray ray = Camera1.ScreenPointToRay(Input.mousePosition/Screen.width);
		//	if (Input.GetMouseButtonDown(0) /*&& Physics.Raycast(ray)==true*/){
			//	NewRandom();
			// Debug.Log(Input.mousePosition.ToString("F4"));
		//	}

    /* if (Input.GetKey(KeyCode.Return)) 
			{
				if(GameObject.Find("byebye") == null) {
			    display.text = "Player 2 wins"; }
			} 

		if(GameObject.Find("byebye") != null){ */

			
		
		//}
	}		
	

	// void OnMouseDown()
  //  {
    //	if (Input.GetMouseButtonDown(0)) {
	//		pressed = 0; }


			 //if (Input.GetMouseButtonDown(0) && pressed == 0){
				//NewRandom();
		         //}

//		     if (Input.GetMouseButtonDown(0)){
//				NewRandom();
//		         }
//	}

	//void NewRandom(){
		//   pressed = 1;
		 void OnMouseOver()
    {
    	if (Input.GetMouseButtonDown(0)){
           System.Random random = new System.Random();
           string quote = options[Random.Range(0, options.Length)];
           display.text = quote;
	} }

}



				


		     
	