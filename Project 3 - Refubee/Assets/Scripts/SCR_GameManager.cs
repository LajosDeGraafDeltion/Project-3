using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_GameManager : MonoBehaviour {

    public SCR_UIManager uiManager;
    public SCR_ConversationManager convManager;
    public SCR_Score openTownGate;
    public int score;

    void Start ()
    {
        uiManager.StartMenu();
        uiManager.pauseOn = false;
    }


    void Update()
    {
        if (score > 25)
        {
            StartCoroutine(openTownGate.GateTimer(9));
            openTownGate.startRot = true;
        }

        if (uiManager.pauseOn = true && Input.GetButtonDown("Cancel"))
        {
            uiManager.PauseMenu();
        }

        else if (uiManager.pauseOn = false && Input.GetButtonDown("Cancel"))
        {
            uiManager.PauseMenuExit();
        }
    }
}
