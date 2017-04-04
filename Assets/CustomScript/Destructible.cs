using System.Collections;
using UnityEngine;

public class Destructible : MonoBehaviour {
	public GameObject debrisPrefab;

	void onMouseDown(){
		DestroyMe();
	}
	void DestroyMe(){
		if (debrisPrefab) {
			Instantiate (debrisPrefab, transform.position, transform.rotation);

		}
		Destroy (gameObject);
		debrisPrefab.transform.position = new Vector3(0, 0, 0);
	}
	void onCollisionEnter( Collision collision){
		
	}
	void Update(){
		DestroyMe ();
	}
}
