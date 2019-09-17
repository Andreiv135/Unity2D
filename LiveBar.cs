using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class LiveBar : MonoBehaviour {

    private Transform[] hearts = new Transform[5];
    private PlatformerCharacter2D character;


    private void Awake()
    {
        character = FindObjectOfType<PlatformerCharacter2D>();
        for (int i =0;i<hearts.Length;i++)
        {
            hearts[i] = gameObject.transform.GetChild(i);
            Debug.Log(hearts[i]);
        }
    
    }
    
    public void Refresh()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < character.Lives)
            {
                hearts[i].gameObject.SetActive(true);
            }
            else
            {
                hearts[i].gameObject.SetActive(false);
            }
        }
    }

}
