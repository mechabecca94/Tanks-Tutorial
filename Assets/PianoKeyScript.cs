using UnityEngine;
using System.Collections;
using UnityEngine.Playables;

public class PianoKeyScript : MonoBehaviour {
	
	public float semitone_offset = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		PlayNote();
	}
	
	void OnCollisionEnter() {
		PlayNote();
	}
	
	void PlayNote() {
		GetComponent<AudioSource>().pitch = Mathf.Pow (2f, semitone_offset/12.0f);
		GetComponent<AudioSource>().Play ();
	}
}
