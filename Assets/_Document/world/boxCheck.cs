using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCheck : MonoBehaviour
{
    public GameObject MenuScene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            MenuScene.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            MenuScene.SetActive(false);
        }
    }
}
