using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMove : MonoBehaviour {
	public GameObject thisone;
	public Animator look;
	public AudioSource[] allMyAudioSources;
	public AudioSource walk;
	public Animation lookTest;
	public int testMoving = 1;

	
	// Use this for initialization
	void Start () {
	Animator look = thisone.GetComponent<Animator>();
	look.Play("swipe", -1, float.NegativeInfinity);
	allMyAudioSources = GetComponents<AudioSource>();
	walk = allMyAudioSources[4];
	walk.enabled = false;
	lookTest = GetComponent<Animation>();

	}


	void Update () {

			if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
			walk.enabled = true;
			}

			if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)){
			walk.enabled = false;
			}

		testMoving = 1;

		if (Input.GetKeyDown(KeyCode.Space)){

         	int index = Random.Range(0,3);
			if (!allMyAudioSources[0].isPlaying&& !allMyAudioSources[1].isPlaying && !allMyAudioSources[2].isPlaying && !allMyAudioSources[3].isPlaying){
		    		for(int i = 0; i < allMyAudioSources.Length; i++){
				allMyAudioSources[index].Play();}
				}	

			StartCoroutine("PlayAnimation");
			if (testMoving == 2){
            StopCoroutine("PlayAnimation");
			}

		}

	//	if (Input.GetKeyUp(KeyCode.Space)){
			//PlayAnimation();

	//	}

	}

private IEnumerator PlayAnimation(){
			look = thisone.GetComponent<Animator>();
			look.enabled = true;
			//allMyAudioSources.enabled=true;

			look.SetFloat("Direction",-1);
			look.Play("swipe",-1,float.NegativeInfinity);

	

			

		    yield return new WaitForSeconds(2);



			testMoving = 2;
			look.enabled = false;


					
		

		//	if (Input.GetKeyUp(KeyCode.Space)){
		//	look.enabled = false;
		//	}



		}

}







