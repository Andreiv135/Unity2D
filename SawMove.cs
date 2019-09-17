using UnityEngine;
using System.Collections;

public class SawMove : MonoBehaviour {

	public int left , right;

	public float speed=1f , xpos;
	void Start () {
		//speed = Random.Range (0, 10) > 5 ? speed : -speed;
		xpos = transform.position.x;

	}


	void Update () {
		if (transform.position.x >= xpos + left || transform.position.x <= xpos - right)
			speed = -speed;
		transform.position += new Vector3 (speed*Time.deltaTime ,0 , 0);
        transform.Rotate(new Vector3(0f, 0f, 1f));
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();
        if (unit && unit is PlatformerCharacter2D)
        {
            unit.ReceiveDemage();
        }
    }
}
