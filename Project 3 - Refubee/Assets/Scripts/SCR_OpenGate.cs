using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_OpenGate : MonoBehaviour {

    public GameObject fenceGate;
    public bool timerDone;
    public bool startRunning;
	
	void Update()
    {
        if (!timerDone && startRunning)
        {
            transform.Rotate(Vector3.up * 10 * Time.deltaTime);
        }
        
        if (timerDone)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 75, 0));
        }
    }

    public IEnumerator Timer(int i)
    {
        yield return new WaitForSeconds(i);
        timerDone = true;
    }
}
