using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllCot : MonoBehaviour
{

    public cot[] cots;

    public Transform cotN0 ;

    public float win = 0;
    public GameObject menu;
    public Text text;

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

        for(int i = 0; i < 7; i++)
        {
            cots[i].CheckChildren();

            cots[i].CanJump = false;
        }

        for (int i = 0; i < 7; i++)
        {
            if(cots[i].Children == 0 )
            {
                if(i-2 >= 0) cots[i - 2].CanJump = true;
                if(i-1 >= 0) cots[i - 1].CanJump = true;
                if(i+1 <= 6) cots[i + 1].CanJump = true;
                if(i+2 <= 6) cots[i + 2].CanJump = true;

                cotN0 = cots[i].GetComponent<Transform>();

            }


        }
    }

    public void CheckWin()
    {

        win = 0;

        for( int i = 0;i < 7; i++)
        {
            foreach(Transform j in cots[i].transform)
            {
                if (j.tag == "Rabbit" && i < 3) win--;
                if (j.tag == "Soc" && i > 3) win--;

                if (cotN0 != cots[3].GetComponent<Transform>() ) win--;
            }

           
        }

        if(win == 0) win = 1;

        if(win == 1)
        {
            menu.SetActive(true);
            text.text = "You win";
            
        }


    }
}
