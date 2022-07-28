using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gamePlay2 : MonoBehaviour
{
    public boatPlus02 boatCode02;

    public GameObject menu;

    public Text text;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckR();
    }


    void CheckR()
    {
        if (boatCode02.lose)
        {
            menu.SetActive(true);
            text.text = "You lose, Fox eat Rabbit";
           
        }

       

        else if ( boatCode02.win)
        {
            menu.SetActive(true);
            text.text = "You win";
         
        }
    }
}
