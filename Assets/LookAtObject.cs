using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour {

	GameObject target;

	// Use this for initialization
	void Start () {
		//target = GameObject.FindWithTag("Player1");
		target = GameObject.Find("Survivor2");

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = new Vector3(target.transform.position.x,
											target.transform.position.y,
											target.transform.position.z);
		transform.LookAt(targetPosition);
	}
}

//referencehttps://www.youtube.com/watch?v=dp3lZUDij6Y