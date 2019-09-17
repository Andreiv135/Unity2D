using UnityEngine;
using System.Collections;

public class FlPlat : MonoBehaviour {


	public float up , down;
	public float speed=1f , ypos;
	void Start () {
		//speed = Random.Range (0, 10) > 5 ? speed : -speed;
		ypos = transform.position.y;

	}
	

	void Update () {

		if (transform.position.y >= ypos + up || transform.position.y <= ypos - down)
			speed = -speed;
		transform.position += new Vector3 (0, speed * Time.deltaTime, 0);
	}
}
