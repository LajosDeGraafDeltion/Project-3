using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_HoneySpawn : MonoBehaviour {

    public SCR_ConversationManager convManager;
    public SCR_GameManager gameManager;
    public GameObject honeySpawn;

    public void InstantiateHoney()
    {
        Instantiate(honeySpawn, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
    }
}
