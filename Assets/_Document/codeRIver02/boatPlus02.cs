using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatPlus02 : MonoBehaviour
{

    public boat boatCode;

    public ground2 GroundR, GroundL;

    public bool lose, win;

    public float Fox, Rabbit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void BoatCheckChildren()
    {
        Fox = Rabbit = 0;

        foreach (Transform i in transform)
        {
            if (i.tag == "Fox") Fox++;
            if (i.tag == "Rabbit") Rabbit++;

        }

        if (boatCode.nearL)
        {
            GroundL.Fox += Fox;
            GroundL.Rabbit += Rabbit;
        }else if (boatCode.nearR)
        {
            GroundR.Fox += Fox;
            GroundR.Rabbit += Rabbit;
        }


        if (GroundR.Fox > GroundR.Rabbit && GroundR.Rabbit > 0) lose = true;

        if (GroundL.Fox > GroundL.Rabbit && GroundL.Rabbit > 0) lose = true;


        if (boatCode.nearL && GroundL.Fox == 3 && GroundL.Rabbit == 3) win = true;


    }


    public void CanGo()
    {
        if (boatCode.children >= 2) boatCode.StartGoToGround(); 
    }
}
