using UnityEngine;
using System.Collections;
using UnityEngine.Playables;

public class PianoKeyScript : MonoBehaviour {
	
	public float semitone_offset = 0;
	Collider this_Collider;
	AudioSource this_audio;
	
	// Use this for initialization
	void Start () {
	this_Collider = this.gameObject.GetComponent<Collider>();
	this_audio = this.gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this_audio != null){
	          if (this.gameObject.GetComponent<MeshRenderer>().enabled == false &&
              this.gameObject.GetComponent<AudioSource>().isPlaying == false)
              {Destroy(this.gameObject);}
          }
	}
	
//	void OnMouseDown() {
//		PlayNote();
//	}
	
	void OnCollisionEnter(Collision collision) {
		if (this.gameObject.GetComponent<MeshRenderer>().enabled = true && GetComponent<AudioSource>() != null){
		PlayNote(); }
	}
	
	void PlayNote() {
		GetComponent<AudioSource>().pitch = Mathf.Pow (2f, semitone_offset/12.0f);
		if (GetComponent<AudioSource>() != null){ 
			GetComponent<AudioSource>().Play (); }
		if (this.gameObject.GetComponent<MeshRenderer>().enabled = true)
           {
              this.gameObject.GetComponent<MeshRenderer>().enabled = false;
              Destroy(this_Collider);
           }
	}
}
