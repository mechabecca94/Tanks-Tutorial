using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Bars14 : MonoBehaviour {

  public List<GameObject> Children; 
    public GameObject respawn;


        
	// Use this for initialization
	void Start () {
		respawn = GameObject.FindWithTag("P2-2");
		respawn.SetActive(false); 
	}
	
	// Update is called once per frame
	void Update () {
	 /* foreach (Transform child in transform)
         {
             if (child.tag == "P2Bars14")
             {
			Debug.Log("active"); 
	             }
         }*/
         
     if (transform.childCount == 0){
     		if (GameObject.FindWithTag("P1-2") != null){
        	    respawn.SetActive(true); 
	         }}
	}

}


           