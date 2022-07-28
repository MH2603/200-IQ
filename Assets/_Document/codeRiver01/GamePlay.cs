using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{

    public ground GroundL,GroundR;

    

    public GameObject menu;
    public Text text;


    bool stop ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!stop) CheckR();
    }


    void CheckR()
    {
        if(GroundR.lose1 || GroundL.lose1)
        {
            menu.SetActive(true);
            text.text = "You lose, Fox eat Rabbit";
     

            stop = true;
        }

        else if (GroundR.lose2 || GroundL.lose2)
        {
            menu.SetActive(true);
            text.text = "You lose, Rabbit eat Snails";
            

            stop = true;
        }

        else if(GroundR.win || GroundL.win)
        {
            menu.SetActive(true);
            text.text = "You win";
            

            stop = true;
        }
    }
}
