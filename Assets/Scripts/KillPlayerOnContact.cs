using UnityEngine;
using System.Collections;

public class KillPlayerOnContact : MonoBehaviour {

	GameManager gm;
	private bool isDead = false;


	// Use this for initialization
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if(other.tag=="Player"){
			//Report losing game here
			isDead = true;

		}

		if(isDead){
			StartCoroutine(gm.restartGame());

		}

		
	}

}
