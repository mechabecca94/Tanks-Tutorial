using UnityEngine;
using System.Collections;

public class endCollide : MonoBehaviour
{
    public GameObject Hero;
    public GameObject endBubble;
    void Start()
    {
        Hero = GameObject.Find("Hero");
        endBubble = GameObject.Find("Finalbubble");
        endBubble.SetActive(false);
    }

    void OnCollisionEnter (Collision col){
       if(col.gameObject.name =="Hero" && col.gameObject.name =="Hero"){
        Destroy(col.gameObject.GetComponent<Rigidbody>());
       }

        if (endBubble.active == false){
            endBubble.SetActive(true);
        }
    }
}