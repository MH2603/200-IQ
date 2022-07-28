using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground2 : MonoBehaviour
{

    public boat boatCode;


    public float Fox, Rabbit;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CheckChildren()
    {
        Fox = Rabbit = 0;

        foreach (Transform i in this.transform)
        {
            if (i.tag == "Fox") Fox ++;
            if (i.tag == "Rabbit") Rabbit ++;
            
        }

        

        return;
    }


}
