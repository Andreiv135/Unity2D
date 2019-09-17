using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject parent;
    public GameObject Parent { set { parent = value; } get { return parent; } }

    private float speed = 10.0f;
    private Vector3 direction;
    public Vector3 Direction { set { direction = value; } }

    public SpriteRenderer sprite;
    void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();

    }
    void Start()
    {
        Destroy(gameObject, 1.4f);
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
       Unit unit = collider.GetComponent<Unit>();
        if (unit&&unit.gameObject !=parent)
        {
            Destroy(gameObject);
        }
    }
}