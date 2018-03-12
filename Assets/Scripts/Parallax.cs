using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {


	//Rock Quad should always be faster than Rock Back

	public float backgroundSpeed;
	private Renderer r;


	// Use this for initialization
	void Start () {
		r = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		r.material.mainTextureOffset = new Vector2 (0 ,Time.time * backgroundSpeed);
	}
}
