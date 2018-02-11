using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warble : MonoBehaviour {
    public GameObject building;

	// Use this for initialization
	void Start () {
	building = GameObject.Find("Building002");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space")){
       building.transform.localScale += new Vector3(1F, 10f, 2f);
        }
	}
}
