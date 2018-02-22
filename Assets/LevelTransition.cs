 using UnityEngine;
  using System.Collections;
  
  public class LevelTransition : MonoBehaviour {
      
      
   public void  Start(){
         StartCoroutine("Wait");
         
      }
 
 IEnumerator Wait()
 {
   yield return new WaitForSeconds(10);
 
 Application.LoadLevel("NewSound");
     }
      }

      //answers.unity.com/questions/883753/c-load-level-after-seconds.html//