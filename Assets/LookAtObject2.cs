using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject2 : MonoBehaviour {

	GameObject target2;

	// Use this for initialization
	void Start () {
		target2 = GameObject.Find("Survivor");
	}
	
	// Update is called once per frame
	void Update () {
		target2 = GameObject.Find("Survivor");
		Vector3 targetPosition = new Vector3(target2.transform.position.x,
											target2.transform.position.y,
											target2.transform.position.z);
		transform.LookAt(targetPosition);
	}
}

//referencehttps://www.youtube.com/watch?v=dp3lZUDij6Y