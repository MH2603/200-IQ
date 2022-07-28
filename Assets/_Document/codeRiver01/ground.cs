using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{

    public boat boatCode;


    public bool isFox, isRabbit, isSnails;

    public bool lose1, lose2, win;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(boatCode.isRunning || boatCode.nearL) CheckChildren();
    }


    void CheckChildren()
    {
        isFox = isRabbit = isSnails = false;
        
        foreach(Transform i in this.transform)
        {
            if(i.name == "FoxButton")       isFox = true;
            if(i.name == "RabbitButton") isRabbit = true;
            if(i.name == "SnailsButton") isSnails = true;
        }

        if (boatCode.isRunning)
        {
            if (isFox && isRabbit) lose1 = true;
            else if (isRabbit && isSnails) lose2 = true;
        }

        if (boatCode.nearL && isFox && isRabbit && isSnails) win = true;    

        return;
    }
}
