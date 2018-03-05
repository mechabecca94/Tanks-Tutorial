using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible: MonoBehaviour {

public GameObject destroyedVersion;

void OnCollisionStay(Collision col){
	 if (col.gameObject.tag == "Finish"){
	 	Instantiate(destroyedVersion, transform.position, transform.rotation);
Destroy(this.gameObject);
	 }
}


void OnMouseDown()
{
Instantiate(destroyedVersion, transform.position, transform.rotation);
Destroy(gameObject);
}

}
