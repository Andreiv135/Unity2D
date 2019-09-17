using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject Prefab;
    private GameObject _enemy;
    public int Collection;
    [SerializeField]
    private GameObject PrefabStar;
    private GameObject _star;
    public int CollectionSt;

    bool Attack = false;

    int i, p;

    // Update is called once per frame
    void Update()
    {
        if (_enemy == null && i < Collection)
        {
            _enemy = Instantiate(Prefab) as GameObject;
            _enemy.transform.position = transform.position;
            i++;
        }

        if (p < CollectionSt && Collection == i && _enemy == null)
        {
            _star = Instantiate(PrefabStar) as GameObject;
            _star.transform.position = transform.position;
            p++;
        }

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        
    }
}