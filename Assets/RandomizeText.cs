using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	 string[] splashes = {"Less than one sold!", "lol","lmao","what?"};
     System.Random random = new System.Random();
     string quote = splashes[Random.Range(0, splashes.Length)];
     GUI.Label(new Rect(50,500,300,100),quote);
	}
	
    
 

	// Update is called once per frame
	void Update () {
	}
}

/*answers.unity.com/questions/323572/c-random-string-array-help.html*/