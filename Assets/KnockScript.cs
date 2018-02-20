using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockScript : MonoBehaviour {

  public AudioClip knock;
  public AudioSource sound;
  private bool playerInBounds;

	// Use this for initialization
	void Start () {
	sound = GetComponent<AudioSource>();
	}
	
	void OnTriggerStay(Collider other){
     if(other.gameObject.name == "AngelTank"){
         playerInBounds = true;
     }
    }

     void OnTriggerExit(Collider other){
     if(other.gameObject.name == "AngelTank"){
         playerInBounds = false;
     }
   }

	// Update is called once per frame
	void Update () {
		 if(playerInBounds && Input.GetKeyDown("space") && (!sound.isPlaying)){
		 	   sound.Play();
		 }
	}


}

