using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textpanel3 : MonoBehaviour {
public Text display;
public Camera Camera1; 
string[] options = 
{"  \n...I must\navenge my\nbrother...",
"...If I sneak\n  around\nthe back...",
"\n\n  ...Why?...",
" \n\n         ...",
" \n\n  ...This is\n my duty...",
"\n\n  ...This is        \n    war...",
"\n...Player\none started\nit...",};

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
		    Ray ray = Camera1.ScreenPointToRay(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !GetComponent<AudioSource>().isPlaying && (Input.mousePosition.x > (Screen.width*.6)) && (Input.mousePosition.y > (Screen.height*.6))){
				NewRandom();
			// Debug.Log(Input.mousePosition.ToString("F4"));
			}

    /* if (Input.GetKey(KeyCode.Return)) 
			{
				if(GameObject.Find("byebye") == null) {
			    display.text = "Player 2 wins"; }
			} 

		if(GameObject.Find("byebye") != null){ */

			
		
		//}
	}		
	

	// void PointerEnter()
  //  {
    //	if (Input.GetMouseButtonDown(0)) {
	//		pressed = 0; }


			 //if (Input.GetMouseButtonDown(0) && pressed == 0){
				//NewRandom();
		         //}

//		     if (Input.GetMouseButtonDown(0)){
	//			NewRandom();
//		         }
	//}

	void NewRandom(){
		//   pressed = 1;
	//	 void OnMouseOver()
   // {
    	//if (Input.GetMouseButtonDown(0)){
		  // if (Input.GetMouseButtonDown(0) && !GetComponent<AudioSource>().isPlaying){
		   GetComponent<AudioSource>().Play ();//}

           System.Random random = new System.Random();
           string quote = options[Random.Range(0, options.Length)];
           display.text = quote;
	} 
//}

}



				


		     
	