using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_UIManager : MonoBehaviour {

    public SCR_GameManager gameManager;
    public GameObject startMenu;
    public GameObject mainMenu;
    public GameObject gameOverlay;
    public GameObject pauseMenu;
    public GameObject player;
    public Camera camera2;
    public Text scoreCount;
    public Text scoreCountShade;
    public Text diaText; //onscreen text
    public Text yesNo;
    public Text pressE;
    public Text eInteract;
    public bool overlayActive;
    public bool pauseOn;

    void Start()
    {
        yesNo.enabled = false;
        pressE.enabled = true;
    }

    void Update ()
    {
		if (overlayActive)
        {
            scoreCount.text = gameManager.score.ToString();
            scoreCountShade.text = gameManager.score.ToString();
        }
	}

    public void StartMenu()
    {
        startMenu.SetActive(true);
        mainMenu.SetActive(false);
        gameOverlay.SetActive(false);
        player.SetActive(false);
        camera2.enabled = true;
        pauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        startMenu.SetActive(false);
        mainMenu.SetActive(true);
        gameOverlay.SetActive(false);
        player.SetActive(false);
        camera2.enabled = true;
        pauseMenu.SetActive(false);
    }

    public void GameOverlay()
    {
        startMenu.SetActive(false);
        mainMenu.SetActive(false);
        gameOverlay.SetActive(true);
        player.SetActive(true);
        camera2.enabled = false;
        overlayActive = true;
        pauseMenu.SetActive(false);
    }

    public void PauseMenu()
    {
        startMenu.SetActive(false);
        mainMenu.SetActive(false);
        gameOverlay.SetActive(true);
        player.SetActive(true);
        camera2.enabled = false;
        overlayActive = true;
        pauseMenu.SetActive(true);
        pauseOn = true;
        Time.timeScale = 0;
    }

    public void PauseMenuExit()
    {
        startMenu.SetActive(false);
        mainMenu.SetActive(false);
        gameOverlay.SetActive(true);
        player.SetActive(true);
        camera2.enabled = false;
        overlayActive = true;
        pauseMenu.SetActive(false);
        pauseOn = false;
        Time.timeScale = 1;
    }

    public void DisplayText(string dialogueText)
    {
        diaText.text = dialogueText;
    }

    public void Question()
    {
        yesNo.enabled = true;
        pressE.enabled = false;
    }

    public void QuestionDisabled()
    {
        yesNo.enabled = false;
        pressE.enabled = true;
    }

    public void InteractActive()
    {
        eInteract.enabled = true;
    }

    public void InteractInactive()
    {
        eInteract.enabled = false;
    }
}
