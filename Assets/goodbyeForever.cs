using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goodbyeForever : MonoBehaviour {
public GameObject finalBubble;
	// Use this for initialization
	void Start () {
				finalBubble = GameObject.FindWithTag("Finalbubble");
	}
	
	// Update is called once per frame
	void Update () {
		finalBubble = GameObject.FindWithTag("Finalbubble");
		if (Input.GetMouseButtonDown(0)){
			exitCheck();
		}
	}

	void OnCollisionEnter(Collision collision) {
		SceneManager.LoadScene ("MainMenu"); 
	}

	void exitCheck(){
		if (finalBubble != null){
			SceneManager.LoadScene("MainMenu");
		}

	}
}
