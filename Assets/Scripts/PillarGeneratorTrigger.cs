using UnityEngine;
using System.Collections;

public class PillarGeneratorTrigger : MonoBehaviour {
	
	[HideInInspector]
	public GameManager gm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other){

		if(other.tag == "Pillar"){
			gm.generatePillars();
		}
		
	}
}
