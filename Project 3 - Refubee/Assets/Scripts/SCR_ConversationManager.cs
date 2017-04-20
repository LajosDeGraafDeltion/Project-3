using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_ConversationManager : MonoBehaviour {

    public SCR_HoneySpawn honeySpawn;
    public SCR_OpenGate openGate;
    public GameObject convBox;
    public Text convText;
    public bool convOn;
    public Transform prefab;

	void Start ()
    {
        convOn = false;
        convBox.SetActive(false);
    }

    void Update()
    {

    }

    public void SetBoxOn()
    {
        convBox.SetActive(true);
        convOn = true;
    }

    public void SetBoxOff()
    {
        convBox.SetActive(false);
        convOn = false;
    }

    public void NPCFunction(int i)
    {
        if (i == 1)
        {
            honeySpawn.InstantiateHoney();
        }
        if (i == 2)
        {
            StartCoroutine(openGate.Timer(9));
            openGate.startRunning = true;
        }
    }
}
