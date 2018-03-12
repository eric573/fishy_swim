using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float pcFakeTiltingSpeed;

	public float tiltingSpeed; 
	public float swimmingSpeed;

	Rigidbody2D rb;


	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void Update () {

		movementPC ();
		movementPhone ();
		tiltingPhone ();

	}
	

	//Debug Method
	void movementPC(){
		
		//PC game check condition
		if (Input.GetKeyDown(KeyCode.Space))
		{
			swimWithVelocity();
		}

		if(Input.GetKeyDown(KeyCode.A)){

			rb.velocity = new Vector2(-pcFakeTiltingSpeed,rb.velocity.y);

		}

		if(Input.GetKeyDown(KeyCode.D)){

			rb.velocity = new Vector2(pcFakeTiltingSpeed,rb.velocity.y);

		}
	}

	//###############################################
	//############Phone##############################
	//############Phone##############################
	//############Phone##############################
	//############Phone##############################
	//############Phone##############################
	//############Phone##############################
	//###############################################

	void movementPhone(){

		//iPhone game check condition
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
			swimWithVelocity(); //alternative is swimWithForce();
		}
	}


	void tiltingPhone(){
		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x * tiltingSpeed * Time.deltaTime;
	
		Vector3 temp = transform.position;
		temp.x += dir.x;
		transform.position = temp;

	}

	//phoneSettings
	
	void swimWithForce(){
		//Rough Estimate 200
		rb.AddForce (Vector2.up * swimmingSpeed);

	}

	void swimWithVelocity(){
		//Rough Estimate 5
		rb.velocity = new Vector2 (rb.velocity.x,swimmingSpeed);

	}

	
	

}
