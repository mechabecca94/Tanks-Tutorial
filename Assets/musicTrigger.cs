using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider trigger){
		Debug.Log("works");
		//if (!this.gameObject.GetComponent<AudioSource>().isPlaying && trigger.gameObject.tag=="lastNote"){
		this.gameObject.GetComponent<AudioSource>().Play();
		//}
	}

}
