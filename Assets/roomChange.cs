﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class roomChange : MonoBehaviour {
public GameObject about;
public GameObject c3;
public GameObject c2;
public GameObject c1;


	// Use this for initialization
	void Start () {
		about = GameObject.Find("aboutButton");
		c3 = GameObject.Find("Menu-3D");
		c2 = GameObject.Find("Menu-NewSound");
		c1 = GameObject.Find("Menu-LightsCamera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()

 { if (this.gameObject.name == "aboutButton"){
     SceneManager.LoadScene("MainMenu");
 	}

 	if (this.gameObject.name == "c3Button"){
     SceneManager.LoadScene("3D");
      Debug.Log("works");
 	}
 	if (this.gameObject.name == "c2Button"){
     SceneManager.LoadScene("NewSound");
     Debug.Log("works");
 	}

 	if (this.gameObject.name =="c1Button"){
     SceneManager.LoadScene("LightsCamera2");
 	}
 }

}


