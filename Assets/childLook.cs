using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childLook : MonoBehaviour {
 Camera cam1;
 Camera cam2;

	// Use this for initialization
	void Start () {
	  cam1 = GameObject.Find("Cam1").GetComponent<Camera>();
	  cam2 = GameObject.Find("Cam2").GetComponent<Camera>();
	 cam1.enabled = true;
     cam2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W)) {
         cam1.enabled = true;
         cam2.enabled = false;
     }
     if (Input.GetKeyDown(KeyCode.UpArrow)) {
         cam2.enabled = true;
         cam1.enabled = false;
     }



	}
}