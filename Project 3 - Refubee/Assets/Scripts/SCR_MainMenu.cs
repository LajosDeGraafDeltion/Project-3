using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_MainMenu : MonoBehaviour {

    public SCR_UIManager uiManager;

    public void StartButton()
    {
        uiManager.GameOverlay();
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
