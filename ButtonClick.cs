using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {
	
	public GameObject ActivPlatform;


	void Start () {
		ActivPlatform=GameObject.Find("platformActiv");
		ActivPlatform.GetComponent<FlPlat> ().enabled = false;

	}
	



	void OnTriggerStay2D (Collider2D activ) {
		if (activ) {

			ActivPlatform.GetComponent<FlPlat> ().enabled = true;


		} 

	
	}
	void OnTriggerExit2D (Collider2D activ) {
		if (activ) {

			ActivPlatform.GetComponent<FlPlat> ().enabled = false;

		} 

			

}
}