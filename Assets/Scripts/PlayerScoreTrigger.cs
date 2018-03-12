using UnityEngine;
using System.Collections;

public class PlayerScoreTrigger : MonoBehaviour {
	[HideInInspector]
	public GameManager gm;

	//Use this for initialization
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			gm.addScore();
			Destroy(this.gameObject);
		}

	}
}
