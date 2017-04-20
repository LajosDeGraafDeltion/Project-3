using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Conv : MonoBehaviour {

    public SCR_ConversationManager convMan;
    public SCR_UIManager uiManager;
    public List<string> convStrings = new List<string>();
    public int count;
    public int npcNumber;
    public bool questions;
    public bool oneTimeConv;
    public bool ableToTalk;
    public bool convDone;
    public bool actionDone;

	void Update ()
    {
        if(ableToTalk && count == 0)
        {
            uiManager.InteractActive();
        } else if (ableToTalk && count > 0)
        {
            uiManager.InteractInactive();
        }

        if (questions && ableToTalk)
        {
            if (Input.GetButtonDown("One"))
            {
                if (convStrings[count + 2] == "!!!")
                {
                    convMan.NPCFunction(npcNumber);
                    uiManager.DisplayText(convStrings[count + 3]);
                    uiManager.QuestionDisabled();
                    count += 5;
                    questions = false;
                    actionDone = true;
                }
                else
                {
                    uiManager.DisplayText(convStrings[count + 3]);
                    uiManager.QuestionDisabled();
                    count += 5;
                    questions = false;
                }
            }
            if (Input.GetButtonDown("Two"))
            {
                if (convStrings[count + 4] == "!!!")
                {
                    convMan.NPCFunction(npcNumber);
                    uiManager.DisplayText(convStrings[count + 5]);
                    uiManager.QuestionDisabled();
                    count += 5;
                    questions = false;
                    actionDone = true;
                }
                else
                {
                    uiManager.DisplayText(convStrings[count + 5]);
                    uiManager.QuestionDisabled();
                    count += 5;
                    questions = false;
                }
            }
        }

        if (Input.GetButtonDown("E") && convMan.convOn && !questions && ableToTalk)
        {

            count++;
            if(count > convStrings.Count - 1)
            {
                if (!oneTimeConv)
                {
                    count = 0;
                }
                else
                {
                    convDone = true;
                }
            }
            if (!convDone)
            {
                if (convStrings[count] == "???")
                {
                    uiManager.DisplayText(convStrings[count + 1]);
                    uiManager.Question();
                    questions = true;
                }

                else
                {
                    uiManager.DisplayText(convStrings[count]);
                }
            }
            
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (!convDone)
        {
            convMan.SetBoxOn();
            ableToTalk = true;
            uiManager.DisplayText("");
        }

    }

    void OnTriggerExit(Collider other)
    {
        convMan.SetBoxOff();
        ableToTalk = false;
        uiManager.DisplayText("");
        count = 0;
        if (questions)
        {
            questions = false;
        }
        if (actionDone)
        {
            convDone = true;
        }
        uiManager.QuestionDisabled();
    }
}
