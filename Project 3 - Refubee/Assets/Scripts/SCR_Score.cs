using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_Score : MonoBehaviour {

    public SCR_GameManager gmManager;
    public GameObject townGate;
    public bool timerEnd;
    public bool startRot;

    void Update()
    {
        if (!timerEnd && startRot)
        {
            transform.Rotate(Vector3.forward * -10 * Time.deltaTime);
        }

        if (timerEnd)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-90, 0, -270));
        }
    }

    public IEnumerator GateTimer(int i)
    {
        yield return new WaitForSeconds(i);
        timerEnd = true;
    }
}
