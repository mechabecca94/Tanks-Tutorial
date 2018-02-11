using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseToot2 : MonoBehaviour {

    public ParticleSystem particles;
    private float tootPitch;         
    public AudioSource tootAudio;    
    public AudioClip tootClip;     
    private float originalToot;           
    public float tootRange = .1f;    //Varies pitch
    public GameObject tooter;

	// Use this for initialization
	void Start () {
	GameObject tooter = GameObject.FindWithTag("tooter");
	}
	
	// Update is called once per frame
	void Update () {
		TootCheck();
	}

	void Toot(){
		if (Input.GetKeyDown("return")) //f = floating point value.
		{
			
				tootAudio.clip = tootClip;
				tootAudio.pitch = Random.Range (originalToot + tootRange, (originalToot + tootRange*3) ); // between 1 and 1.2
				tootAudio.Play();
				particles.Emit(1);

	    }
	    	  	if(Input.GetKeyUp("return"))
	  			 {
        		 particles.Stop();
        		 }
 		}

 	void TootCheck(){
 		if(tooter != null) {
 			audioSource = tooter.GetComponent<AudioSource>();
 			if (audioSource.isPlaying){
 				print("worked!");
 			}
 		}
 	}

}
