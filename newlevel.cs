using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newlevel : MonoBehaviour {
	public string LvlName;
    public Canvas menu;
    public Canvas Point;
    public Canvas MobileSingleStickControl;


    GameObject Character;
    void Start() {
        Character = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter2D(Collider2D pes)
    {
        
        if (pes.CompareTag("Player"))
        {
            if (GameObject.Find("Коленька малышь").GetComponent<PickKey>().key == 1)
            {
                Destroy(Character);
                Point.gameObject.SetActive(true);
                menu.gameObject.SetActive(false);
                MobileSingleStickControl.gameObject.SetActive(false);

            }
		}
	}
}

