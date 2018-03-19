using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class leave : MonoBehaviour
{

public GameObject GUICanvas;

void Start()
{

}

void OnTriggerEnter (Collider other)
{
    if (other.gameObject.tag == ("Finish"))
    {
        GUICanvas.SetActive(true);
    }

}

void OnTriggerExit (Collider other)
{
if (other.gameObject.tag == ("Finish"))
    {
        GUICanvas.SetActive(false);
    }
}

 void OnCollisionStay(Collision other) {
        
        if (Input.GetKeyDown(KeyCode.Return)){
          //  Debug.Log("Hello");
        Application.Quit();
    }
 }

void Update()
{
        if (GUICanvas.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Return)){
          //  Debug.Log("Hello");
        Application.Quit();
        }
}


}