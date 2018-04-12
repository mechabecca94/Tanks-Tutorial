using UnityEngine; 
using System.Collections;
 using UnityEngine.UI;


public class Hide : MonoBehaviour {
	public GameObject mytext;
// Use this for initialization
void Start () {
	mytext = GameObject.Find("MessageCanvas");
	       mytext.SetActive(true); 
}

// Update is called once per frame
void Update () {

    if (Input.GetKeyDown(KeyCode.Space)){ 
        // show     
       mytext.SetActive(true); 
    }

    if (Input.GetKeyUp(KeyCode.Space)|| Input.GetKeyDown(KeyCode.LeftArrow)  || Input.GetKeyDown(KeyCode.RightArrow)  || Input.GetKeyDown(KeyCode.UpArrow)  || Input.GetKeyDown(KeyCode.DownArrow)) { 
       // hide 
       mytext.SetActive(false); 
  }
}
}