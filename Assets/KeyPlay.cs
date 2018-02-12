using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPlay : MonoBehaviour {

  public GameObject keyC;
  public GameObject keyD;
  public GameObject keyE;
  public GameObject keyF;
  public GameObject keyG;
  public AudioSource KeyAudio;
  private bool playerOneInBounds;
  private bool playerTwoInBounds;


	// Use this for initialization
	void Start () {
		GameObject keyC = GameObject.FindWithTag("C");
		GameObject keyD = GameObject.FindWithTag("D");
		GameObject keyE = GameObject.FindWithTag("E");
		GameObject keyF = GameObject.FindWithTag("F");
		GameObject keyG = GameObject.FindWithTag("G");

	}


	void OnTriggerStay(Collider other){
     if(other.gameObject.name == "AngelTank"){
         playerOneInBounds = true;
     }
    

     if(other.gameObject.name == "AngelTank2"){
         playerTwoInBounds = true;
     }
   
   }


     void OnTriggerExit(Collider other){
     if(other.gameObject.name == "AngelTank"){
         playerOneInBounds = false;
     }

      if(other.gameObject.name == "AngelTank2"){
      playerTwoInBounds = false;
   }
}
	// Update is called once per frame
	void Update () {

		 	if(playerOneInBounds && Input.GetKey("space") && (!KeyAudio.isPlaying)){
		 	PlayerInBounds(); 
		 }

		 	if(playerTwoInBounds && Input.GetKey("return") && (!KeyAudio.isPlaying)){
		 	PlayerInBounds();
		}
	}

            void PlayerInBounds(){

		 		if (this.gameObject.tag == "C"){
		 		KeyAudio = keyC.GetComponent<AudioSource>();
				KeyAudio.Play();
		 		}

		 		if (this.gameObject.tag == "D"){
		 		KeyAudio = keyD.GetComponent<AudioSource>();
				KeyAudio.Play();
		 		}

		 		if (this.gameObject.tag == "E"){
				KeyAudio = keyE.GetComponent<AudioSource>();
				KeyAudio.Play();
		 		}

		 		if (this.gameObject.tag == "F"){
		 		KeyAudio = keyF.GetComponent<AudioSource>();
				KeyAudio.Play();
		 		}

		 		if (this.gameObject.tag == "G"){
		 		KeyAudio = keyG.GetComponent<AudioSource>();
				KeyAudio.Play();
		 		}
		  }

}


