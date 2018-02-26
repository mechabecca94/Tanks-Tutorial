using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Bars14 : MonoBehaviour {

  public List<GameObject> Children; 
  public GameObject respawn1;
  public GameObject respawn2;
  public GameObject respawn3;

        
	// Use this for initialization
	void Start () {
		respawn1 = GameObject.FindWithTag("P1-2");
		respawn1.SetActive(false); 

		respawn2 = GameObject.FindWithTag("P1-3");
		respawn2.SetActive(false);

		respawn3 = GameObject.FindWithTag("P1-4");
		respawn3.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	/* foreach (Transform child in transform)
         {
             if (child.tag == "P1Bars14")
             {
			Debug.Log("active"); 
	             }
         }*/
         
     if (this.transform.childCount < 8){
        	    respawn1.SetActive(true); 
	         }
	 if (respawn1.transform.childCount < 8){
        	    respawn2.SetActive(true); 
	  }

 	if (respawn2.transform.childCount < 8){
        	    respawn3.SetActive(true); 
	  }

	}


	

}


           