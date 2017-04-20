using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_PickupItem : MonoBehaviour {

    public SCR_GameManager manager;

    void Start()
    {
       manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<SCR_GameManager>();
        
    }

    void OnCollisionEnter(Collision c)
    {

        if (c.gameObject.tag == "Player" && gameObject.tag == "HoneyComb")
        {           
            c.gameObject.GetComponent<SCR_PlayerInventory>().playerInv.Add(gameObject);

            manager.score ++;
            gameObject.SetActive(false);
        }

        if (c.gameObject.tag == "Player" && gameObject.tag == "HoneyPot")
        {
            c.gameObject.GetComponent<SCR_PlayerInventory>().playerInv.Add(gameObject);

            manager.score += 5;
            gameObject.SetActive(false);
        }
    }
}
