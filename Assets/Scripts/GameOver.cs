﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void OnGUI()
    {
        GUI.contentColor = Color.red;
        if(GUI.Button(new Rect(Screen.width/2-50, Screen.height/2 +50, 100, 40), "Retry?"))
        {
            Application.LoadLevel(0);
        }
       
    }
}
