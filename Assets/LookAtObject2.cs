using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject2 : MonoBehaviour {

	GameObject target2;
	GameObject eye;

	// Use this for initialization
	void Start () {
		target2 = GameObject.Find("CubeLook");
		eye = GameObject.Find("Eye2");
	}
	
	// Update is called once per frame
	void Update () {
		target2 = GameObject.Find("CubeLook");
		Vector3 targetPosition = new Vector3(target2.transform.position.x,
											target2.transform.position.y,
											target2.transform.position.z);
		transform.LookAt(targetPosition);

		if (eye.transform.eulerAngles.y < 50f || eye.transform.eulerAngles.y > -50f) {
 			 transform.LookAt(targetPosition);
 		}

 		else if (eye.transform.eulerAngles.y > 50f || eye.transform.eulerAngles.y < -50f) {
 			 Vector3 targetPosition2 = new Vector3(0,0,0);
 			 transform.LookAt(targetPosition2);
 		}
 	}

    /*    float angle2 = Vector3.Angle(targetPosition, transform.up);
        if (angle2 > 15.0f){
            targetPosition.Set(0,0,0);
        }
		float angle = Vector3.Angle(targetPosition, transform.forward);
        if (angle > 5.0f){
            targetPosition.Set(-14.717f,0,0);
        }

        if (transform.eulerAngles.y > 50.0f || transform.eulerAngles.y < -50f ){
            targetPosition.Set(0,0,0);
        } */


	
}

//referencehttps://www.youtube.com/watch?v=dp3lZUDij6Y