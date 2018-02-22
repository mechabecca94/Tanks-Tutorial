using UnityEngine;
using System.Collections;
using UnityEngine.Playables;

public class PianoKeyScript : MonoBehaviour {
	
	public float semitone_offset = 0;
	Collider this_Collider;
	
	// Use this for initialization
	void Start () {
	this_Collider = this.gameObject.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
	          if (this.gameObject.GetComponent<MeshRenderer>().enabled == false &&
              this.gameObject.GetComponent<AudioSource>().isPlaying == false)
              {Destroy(this.gameObject);}
	}
	
	void OnMouseDown() {
		PlayNote();
	}
	
	void OnCollisionEnter() {
		if (this.gameObject.GetComponent<MeshRenderer>().enabled = true){
		PlayNote(); }
	}
	
	void PlayNote() {
		GetComponent<AudioSource>().pitch = Mathf.Pow (2f, semitone_offset/12.0f);
		GetComponent<AudioSource>().Play ();
		if (this.gameObject.GetComponent<MeshRenderer>().enabled = true)
           {
              this.gameObject.GetComponent<MeshRenderer>().enabled = false;
              Destroy(this_Collider);
           }
	}
}
