using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalButton : MonoBehaviour
{

    public boat boatCode;

    public Transform boat;
    public Transform GroundR;
    public Transform GroundL;   

    public Transform posOnR;
    public Transform posOnL;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {

        

        if(boatCode.nearR)
        {
            if( this.transform.parent == boat)
            {
                this.transform.position = posOnR.position;
                this.transform.SetParent(GroundR);

                boatCode.children--;
            }
            else if (transform.parent == GroundR && boatCode.children <= 1 )
            {
                this.transform.position = new Vector3(boat.position.x, boat.position.y + 2, boat.position.z);
                this.transform.SetParent(boat);

                boatCode.children++;
            }
        }

        if (boatCode.nearL)
        {
            if (this.transform.parent == boat)
            {
                this.transform.position = posOnL.position;
                this.transform.SetParent(GroundL);

                boatCode.children--;
            }
            else if (transform.parent == GroundL && boatCode.children <= 1)
            {
                this.transform.position = new Vector3(boat.position.x, boat.position.y + 2, boat.position.z);
                this.transform.SetParent(boat);

                boatCode.children++;
            }

            
        }
    }

}
