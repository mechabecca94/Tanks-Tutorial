using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

void FixedUpdate () {
     
                     if(!Input.anyKey){
                     	this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
						this.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                     	}
                     }

}
