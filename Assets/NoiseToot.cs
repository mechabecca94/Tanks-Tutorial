using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseToot : MonoBehaviour {

    public ParticleSystem particles;
    private float tootPitch;         
    public AudioSource tootAudio;    
    public AudioClip tootClip;     
    private float originalToot;           
    public float tootRange = .1f;    //Varies pitch

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Toot();
	}

	void Toot(){
		if (Input.GetKeyDown("space")) //f = floating point value.
		{
			
				tootAudio.clip = tootClip;
				tootAudio.pitch = Random.Range (originalToot + tootRange, (originalToot + tootRange*3) ); // between 1 and 1.2
				tootAudio.Play();
				particles.Emit(1);

	    }
	    	  	if(Input.GetKeyUp("space"))
	  			 {
        		 particles.Stop();
        		 }
 		}

}
