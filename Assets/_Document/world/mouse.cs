﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{

    public Texture2D cursor,cursorDown;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MouseButtonDown()
    {
        Cursor.SetCursor(cursorDown, Vector2.zero, CursorMode.ForceSoftware);
    }
}
