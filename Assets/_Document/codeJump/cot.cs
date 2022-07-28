using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cot : MonoBehaviour
{

    public bool CanJump;

    public float Children = 1;

    
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
        Children = 0;
        foreach(Transform i in transform)
        {
            if (i != null) Children++;
        }
    }
}
