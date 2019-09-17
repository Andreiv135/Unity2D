using UnityEngine;
using System.Collections;

public class PickKey : MonoBehaviour {

	public int key,point;

	void Start () {
	
	}
	

	void OnCollisionEnter2D (Collision2D keys) {
		if(keys.collider.CompareTag("key")){
			key++;

			Destroy (keys.gameObject);
		}
	}

}
