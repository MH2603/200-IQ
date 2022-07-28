using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalButton2 : MonoBehaviour
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



        if (boatCode.nearR)
        {
            if (this.transform.parent == boat)
            {
                if (this.transform.position.x -  boat.transform.position.x > 0) boatCode.R = false;
                else  boatCode.L = false;

                this.transform.position = posOnR.position;
                this.transform.SetParent(GroundR);

                

                boatCode.children--;
            }
            else if (transform.parent == GroundR && boatCode.children <= 2)
            {
                if(!boatCode.R)
                {
                    this.transform.position = new Vector3(boat.position.x + 0.5f, boat.position.y + 0.5f, boat.position.z);
                    this.transform.SetParent(boat);

                    boatCode.R = true;
                    boatCode.children++;


                }else if(!boatCode.L)
                {
                    this.transform.position = new Vector3(boat.position.x - 0.5f, boat.position.y + 0.5f, boat.position.z);
                    this.transform.SetParent(boat);

                    boatCode.L = true;
                    boatCode.children++;
                }
                
            }
        }

        if (boatCode.nearL)
        {
            if (this.transform.parent == boat)
            {
                if (this.transform.position.x - boat.transform.position.x > 0) boatCode.R = false;
                else boatCode.L = false;

                this.transform.position = posOnL.position;
                this.transform.SetParent(GroundL);

                boatCode.children--;
            }
            else if (transform.parent == GroundL && boatCode.children <= 2)
            {
                if (!boatCode.R)
                {
                    this.transform.position = new Vector3(boat.position.x + 0.5f, boat.position.y + 0.5f, boat.position.z);
                    this.transform.SetParent(boat);

                    boatCode.R = true;
                    boatCode.children++;


                }
                else if (!boatCode.L)
                {
                    this.transform.position = new Vector3(boat.position.x - 0.5f, boat.position.y + 0.5f, boat.position.z);
                    this.transform.SetParent(boat);

                    boatCode.L = true;
                    boatCode.children++;
                }

            }


        }
    }

}
