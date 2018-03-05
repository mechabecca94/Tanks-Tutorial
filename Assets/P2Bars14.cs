using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Bars14 : MonoBehaviour {

  public List<GameObject> Children; 
    public GameObject respawn1;
    public GameObject respawn2;
    public GameObject respawn3;
    public GameObject respawn4;
    public GameObject otherNote;

        
	// Use this for initialization
	void Start () {		

		otherNote = GameObject.FindWithTag("P1-4");

		respawn1 = GameObject.FindWithTag("P2-2");
		respawn1.SetActive(false); 

		respawn2 = GameObject.FindWithTag("P2-3");
		respawn2.SetActive(false); 

		respawn3 = GameObject.FindWithTag("P2-4");
		respawn3.SetActive(false); 

		respawn4 = GameObject.FindWithTag("LastNote");
		respawn4.SetActive(false);
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

     if (this.transform.childCount == 0){
     		if (GameObject.FindWithTag("P1-2") != null){
        	    respawn1.SetActive(true); 
	         }}

	 if (respawn1.transform.childCount == 0){
     		if (GameObject.FindWithTag("P1-3") != null){
        	    respawn2.SetActive(true); 
	         }}

	 if (respawn2.transform.childCount == 0){
     		if (GameObject.FindWithTag("P1-4") != null){
        	    respawn3.SetActive(true); 
	         }}

	if (respawn3.transform.childCount < 1 && otherNote.transform.childCount < 1 ){
        	    respawn4.SetActive(true); 
	  }
	}

}


           