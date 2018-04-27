 using UnityEngine;
  using System.Collections;
  using UnityEngine.SceneManagement;
  
  public class LevelTransition : MonoBehaviour {
	string sceneName;
      
   public void  Start(){
   	   sceneName = SceneManager.GetActiveScene().name;
         StartCoroutine("Wait");
      }
 
 IEnumerator Wait()
 {
 	if (sceneName == "Menu-NewSound"){
    yield return new WaitForSeconds(10);
    Application.LoadLevel("NewSound");
}

   if (sceneName == "Menu-LightsCamera"){
   yield return new WaitForSeconds(6);
   Application.LoadLevel("LightsCamera2");
}

     }
      }

      //answers.unity.com/questions/883753/c-load-level-after-seconds.html//