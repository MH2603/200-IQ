using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJump : MonoBehaviour
{

    public AllCot AllCotCode;

   
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
        AllCotCode.CheckChildren();

        if (this.transform.parent.GetComponent<cot>().CanJump )
        {
            if( this.transform.tag == "Rabbit" && (transform.position.x - AllCotCode.cotN0.position.x) < 0)
            {
                this.transform.SetParent(AllCotCode.cotN0);
                this.transform.position = AllCotCode.cotN0.position;
            }

            if (this.transform.tag == "Soc" && (transform.position.x - AllCotCode.cotN0.position.x) > 0)
            {
                this.transform.SetParent(AllCotCode.cotN0);
                this.transform.position = AllCotCode.cotN0.position;
            }
        }

        AllCotCode.CheckChildren();

        AllCotCode.CheckWin();

    }
}
