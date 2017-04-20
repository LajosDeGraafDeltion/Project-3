using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_PauseMenu : MonoBehaviour {

    public SCR_UIManager uiManager;

    public void ResumeButton()
    {
        uiManager.PauseMenuExit();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
