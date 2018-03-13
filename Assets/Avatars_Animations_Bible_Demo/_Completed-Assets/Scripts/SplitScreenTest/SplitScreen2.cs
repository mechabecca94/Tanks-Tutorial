using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen2 : MonoBehaviour {
	
	public Camera Cam2;
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey(KeyCode.Return)& GameObject.Find("Survivor") != null)  
		{
		   Cam2.rect = new Rect(0,0,0.5f,1f); 
		}

		  else 
		  { 
		  	Cam2.rect = new Rect(0,0,0,0); 
		  }
	}

	/*public void ChangeSplitScreen()
	{
		Horizontal = !Horizontal;

		if(Horizontal) {
			Cam1.rect = new Rect(0,0,0,0);
		}
		else {
			Cam1.rect = new Rect(0.5f,0,0.5f,1f);
		}
	}*/

}