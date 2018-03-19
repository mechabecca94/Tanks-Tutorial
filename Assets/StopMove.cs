using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMove : MonoBehaviour {
	public GameObject thisone;
	public Animator look;
	public AudioSource[] allMyAudioSources;
	public AudioSource walk;

	
	// Use this for initialization
	void Start () {
	Animator look = thisone.GetComponent<Animator>();
	look.Play("swipe", -1, float.NegativeInfinity);
	allMyAudioSources = GetComponents<AudioSource>();
	walk = allMyAudioSources[4];
	walk.enabled = false;

	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			look.enabled = true;
			look = thisone.GetComponent<Animator>();
			look.SetFloat("Direction",-1);
			look.Play("swipe",-1,float.NegativeInfinity);

			for(int i = 0; i < allMyAudioSources.Length; i++){
         
			if (!allMyAudioSources[0].isPlaying&& !allMyAudioSources[1].isPlaying && !allMyAudioSources[2].isPlaying && !allMyAudioSources[3].isPlaying){
				int index = Random.Range(0,3);
			allMyAudioSources[index].Play();
				}	
			}
		
		}

			if (Input.GetKeyUp(KeyCode.Space)){
			look.enabled = false;
			}

			if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
			walk.enabled = true;
			}

			if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)){
			walk.enabled = false;
			}

	}




}




