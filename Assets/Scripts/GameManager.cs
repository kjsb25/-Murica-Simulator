﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    //----------------------------------------
    // handles
    public Canvas UI;

    void Update()
    {

        //uses the p button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        // not the optimal way but for the sake of readability
        if (UI.GetComponentInChildren<Canvas>().enabled)
        {
            UI.GetComponentInChildren<Canvas>().enabled = false;
            Time.timeScale = 1.0f;
        }
        else
        {
            UI.GetComponentInChildren<Canvas>().enabled = true;
            Time.timeScale = 0f;
        }
        
        Debug.Log("GAMEMANAGER:: TimeScale: " + Time.timeScale);
    }

}