using UnityEngine;
using System.Collections;

public class PillarDestroyTrigger : MonoBehaviour {

	void OnTriggerExit2D(Collider2D other){
	
		if(other.tag == "Pillar"){
			Destroy(other.transform.parent.gameObject);
		}
	}


}
