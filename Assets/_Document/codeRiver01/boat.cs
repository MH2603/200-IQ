using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{


    public Transform posL, posR;

    public bool nearR,nearL,isRunning;

    public int direction = 0;
    public float speed = 0.1f;

    public int children = 1;

    public bool L, R;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        nearR = CheckPos(posR);
        nearL = CheckPos(posL);
        if (!nearL && !nearR)
        {
            isRunning = true;
        }

        GoToGround();

        
    }


    bool CheckPos(Transform pos)
    {
        if (Mathf.Abs(transform.position.x - pos.position.x) <= 0.8f)
        {
            isRunning = false;
            return true;
        }
        else return false;  
    }

    public void StartGoToGround()
    {

        if (nearR) direction = -1;
        else if (nearL) direction = 1;

    }

    void GoToGround()
    {

        Vector3 k = transform.localScale;

        if (direction == -1)
        {
            
            transform.position = Vector3.Lerp(transform.position, posL.position, speed);

        }
        if (direction == 1)
        {
           
            transform.position = Vector3.Lerp(transform.position, posR.position, speed);
        }

        transform.localScale = k;
    }
    

    public void CheckChildren()
    {
        foreach (Transform i in this.transform)
        {
            if (i != null) children++;
        }
    }

}
