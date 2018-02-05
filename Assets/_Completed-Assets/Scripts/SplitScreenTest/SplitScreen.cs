using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitScreen : MonoBehaviour {
	
	public Camera Cam1;
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey(KeyCode.Space) && GameObject.Find("Survivor2") != null) 
		{
			 Cam1.rect = new Rect(.5f,0,1f,1f); 
		}

		  else 
		  { 
		  	Cam1.rect = new Rect(0,0,0,0); 
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
