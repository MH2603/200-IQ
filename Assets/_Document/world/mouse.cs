using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{

    public Texture2D[] cursors;

    // Start is called before the first frame update
    void Start()
    {
        SetMouse();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetMouse();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            SetMouse();
        }
    }

    void SetMouse() 
    {
        int k = Random.Range(0,cursors.Length);

        Cursor.SetCursor(cursors[k], Vector2.zero, CursorMode.ForceSoftware);
    }
}
