using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitchKill : MonoBehaviour {

  public AudioClip knock;
  public AudioSource sound;
  private bool playerInBounds;
  public int startingPitch = 4;
  public GameObject me;


	// Use this for initialization
	void Start () {
	GameObject me = GameObject.FindWithTag("me");
	sound = me.GetComponent<AudioSource>();
	sound.pitch =  startingPitch;

	}
	

	// Update is called once per frame
	void Update () {
		
		if(playerInBounds && Input.GetKeyDown("space") && (!sound.isPlaying)){
		 	   sound.pitch =  startingPitch + 2;
		 	   sound.Play();
		 }

		 else if(!playerInBounds && Input.GetKeyDown("space") && (!sound.isPlaying)){
		 	   sound.pitch =  startingPitch - 2;
		 	   sound.Play();
		 }
	}

	void OnTriggerStay(Collider other){
     if(other.gameObject.tag == "me"){
         playerInBounds = true;
     }
    }

	void OnTriggerExit(Collider other){
     if(other.gameObject.name == "me"){
         playerInBounds = false;
     }
   }


}









     
