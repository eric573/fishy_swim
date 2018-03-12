using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

	public GameObject pillars;
	public GameObject spawnLocationReference;
	static private int score;
	public Text txtScore;
	public int scorePoints;
	public float rangeMinX;
	public float rangeMaxX;
	
	bool pauseInput = false; 		//to break if staement in update
	// Use this for initialization

	void Awake(){
		pauseGame (true);			//pause the game
		GameObject.Find ("TapToStart").GetComponent<Image> ().enabled = true;
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && pauseInput == false) {	// need to change to touch
			GameObject.Find ("TapToStart").SetActive(false);
			GameObject.Find ("Tilt").SetActive(false);
			pauseGame(false);		//unpause the game
			pauseInput = true;		//break state if
		}

		showScore ();				
	}

	public void addScore(){

		score += scorePoints;	

	}

	public void showScore(){

		txtScore.text = "" + score;
	}

	public void generatePillars(){

		float number = Random.Range (rangeMinX, rangeMaxX);
		Vector2 position = new Vector2 (number,spawnLocationReference.transform.position.y);

		//Destroy Pillars
		Instantiate (pillars, position, pillars.transform.rotation);
	}

	public IEnumerator restartGame(){
		pauseGame (true);
		GameObject.Find ("PlayerAnim").GetComponent<Animator> ().enabled = true;
		score = 0;
		float pauseTime = Time.realtimeSinceStartup + 0.5f;

		while (Time.realtimeSinceStartup < pauseTime) {		//used realtimeSinceStartup cuz when timescale = 0,waitforseconds doesnt work
			yield return 0;
		}

		pauseGame (false);
		Application.LoadLevel (Application.loadedLevel);
	}

	public void highScore(){
		pauseGame (true);
	}
	
	public void pauseGame(bool pause){
		if (pause == true) {
			Time.timeScale = 0;
			GameObject.Find("Player").GetComponent<Player>().tiltingSpeed = 0;
		}
		else if(pause == false){
			Time.timeScale = 1;
			GameObject.Find("Player").GetComponent<Player>().tiltingSpeed = 18;
		}
	}






	 
}
