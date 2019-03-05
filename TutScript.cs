using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutScript : MonoBehaviour {

    public GameObject JumpUI;
    public GameObject MoveUI;
    public static bool JState = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveUI.SetActive(false);
            JumpUI.SetActive(true);
            JState = true;


        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (JState) { 
                JumpUI.SetActive(false);
                Destroy(JumpUI);
            }
        }
    }
}

    