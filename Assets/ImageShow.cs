 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class ImageShow : MonoBehaviour {
 
     public bool isImgOn;
     public Image img;
 
     void Start () {
 
         img.enabled = true;
         isImgOn = true;
     }
 
     void Update () {
     
         if (Input.GetKeyDown ("KeyCode.Space")) {
 
             if (isImgOn == true) {
 
                 img.enabled = false;
                 isImgOn = false;
             }
 
             else {
 
                 img.enabled = true;
                 isImgOn = true;
             }
         }
     }
 }

//answers.unity.com/questions/1173902/how-to-make-a-ui-image-appeardisappear.html