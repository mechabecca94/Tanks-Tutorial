﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
public class ScreenFader2 : MonoBehaviour {
#region FIELDS
public Image fadeOutUIImage;
public float fadeSpeed = 0.8f; 
public enum FadeDirection

{
In, //Alpha = 1
Out // Alpha = 0
}
#endregion
#region MONOBHEAVIOR
public GameObject byeDoor;
void OnEnable()
{
byeDoor = GameObject.FindWithTag("byeDoor");
	byeDoor.SetActive(false);
	StartCoroutine(Fade(FadeDirection.In));
}

#endregion
#region FADE
private IEnumerator Fade(FadeDirection fadeDirection) 
{
	 byeDoor.SetActive(true);
 yield return new WaitForSeconds(9);
SceneManager.LoadScene("MainMenu");

float alpha = (fadeDirection == FadeDirection.Out)? 1 : 0;
float fadeEndValue = (fadeDirection == FadeDirection.Out)? 0 : 1;
if (fadeDirection == FadeDirection.Out) {
while (alpha >= fadeEndValue)
{
SetColorImage (ref alpha, fadeDirection);
yield return null;
}
fadeOutUIImage.enabled = false; 
} else {
fadeOutUIImage.enabled = true; 
while (alpha <= fadeEndValue)
{
SetColorImage (ref alpha, fadeDirection);
yield return null;
}
}
}
#endregion
#region HELPERS
public IEnumerator FadeAndLoadScene(FadeDirection fadeDirection, string sceneToLoad) 
{
yield return Fade(fadeDirection);
SceneManager.LoadScene("MainMenu");

}
private void SetColorImage(ref float alpha, FadeDirection fadeDirection)
{
fadeOutUIImage.color = new Color (fadeOutUIImage.color.r,fadeOutUIImage.color.g, fadeOutUIImage.color.b, alpha);
alpha += Time.deltaTime * (1.0f / fadeSpeed) * ((fadeDirection == FadeDirection.Out)? -1 : 1) ;
}
#endregion
}

//sourcehttp://gamedevelopertips.com/unity-how-fade-between-scenes/