using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {

	public Texture2D fadeOutTexture; 		//the texture
	public float fadeSpeed = 0.8f;			//the fading speed

	private int drawDepth = -10; 			//the order layer
	private float alpha = 1.0f;				//the texture alpha between 0 and 1
	private int fadeDir = -1; 				//the direction to fade in:-1 or out:1	


	void OnGUI(){
		//fadeDir out/int the alpha value using direction, speed, time.deltatime
		alpha += fadeDir * fadeSpeed * Time.unscaledDeltaTime;
		//force(clamp) the number between 0 and 1 cuz alpha uses 1 and 0 value
		alpha = Mathf.Clamp01 (alpha);

		//set colour of GUI
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;				//making sure layer order
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
	}

	//set fadeDir parameter to be used from other classes
	public float BeginFade(int direction){
		fadeDir = direction;
		return (fadeSpeed);
	}
	//OnLevelwasLoaded is called when a level is loaded
	public void OnLevelWasLoaded(){
		BeginFade (-1);
	}
}
