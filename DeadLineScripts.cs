using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeadLineScripts : MonoBehaviour {
	public Scene ActivScene;


	//Vector3 beggin;

	//void Start () {
	//	beggin = GameObject.Find("pers").transform.position;

	//}
	

	void OnTriggerEnter2D(Collider2D pers) {
		if (pers.CompareTag ("Player")) {

			//pers.transform.position = beggin;
			//Application.LoadLevel("scene1");
			//SceneManager.LoadScene ("scene1");
			ActivScene = SceneManager.GetActiveScene();
			SceneManager.LoadScene (ActivScene.name);

			//Debug.Log (namescene);
		}

	}
}
