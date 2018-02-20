using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseToot2 : MonoBehaviour {

   // public ParticleSystem particles;
    private float tootPitch;         
    public AudioSource tootAudio;    
    public AudioClip tootClip;     
    private float originalToot;           
    public float tootRange = .1f;    //Varies pitch
    public GameObject tooter;
    public AudioSource audioSourceDate;
    public AudioSource audioSourceMe;


	// Use this for initialization
	void Start () {
	GameObject tooter = GameObject.FindWithTag("tooter");
	 audioSourceDate = tooter.GetComponent<AudioSource>();

 	GameObject me = GameObject.FindWithTag("me");
         audioSourceMe = me.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		Toot();
		TootCheck();
	}



	void Toot(){
		if (Input.GetKeyDown("space")) //f = floating point value.
		{
			
				tootAudio.clip = tootClip;
			//	tootAudio.pitch = Random.Range (originalToot + tootRange, (originalToot + tootRange*3) ); // between 1 and 1.2
				tootAudio.Play();
		//		particles.Emit(1);

	    }
	     	/* if(Input.GetKeyUp("space"))
	  			 {
        		 particles.Stop();
        		 } */
 		} 

 	void TootCheck(){
 			if (audioSourceDate.isPlaying && audioSourceMe.isPlaying){
 			//	if (audioSourceDate.pitch == audioSourceMe.pitch){
				print("worked!");
 		   //		 }	
 		    }
 	}

}
