using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideTV : MonoBehaviour {
	public GameObject video;
	public GameObject realCube;


	// Use this for initialization
	void Start () {
		video.SetActive(true);
		video.SetActive(false);
		realCube.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider col){
		if (col.name == "COLLIDE"){
			video.SetActive(false);
			realCube.SetActive(true);}		
	}

	void OnTriggerStay(Collider col){
		if (col.name == "COLLIDE" ){
				video.SetActive(true);
				realCube.SetActive(false);
			}
	}

}



