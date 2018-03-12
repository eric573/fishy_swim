using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManagerMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine(StartGame ());
	}
	public void Play(){
		StartCoroutine (StartGame());
	}

	IEnumerator StartGame(){
		float fadeTime = GameObject.Find ("GameManager").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	 
}
