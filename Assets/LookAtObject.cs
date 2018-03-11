using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour {

	GameObject target;
	Vector3 targetPosition1;

	// Use this for initialization
	void Start () {
		//target = GameObject.FindWithTag("Player1");
		target = GameObject.Find("LOOK");

	}
	
	// Update is called once per frame
	void Update () {
				target = GameObject.Find("LOOK");
		Vector3 targetPosition1 = new Vector3(target.transform.position.x,
											target.transform.position.y,
											target.transform.position.z);
		transform.LookAt(targetPosition1);
												
	}
}

//referencehttps://www.youtube.com/watch?v=dp3lZUDij6Y