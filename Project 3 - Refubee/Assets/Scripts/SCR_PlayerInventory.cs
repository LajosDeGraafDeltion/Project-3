using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerInventory : MonoBehaviour {

    public List<GameObject> playerInv = new List<GameObject>();
    public List<GameObject> wingInv = new List<GameObject>();
    public string wingTag;
    public int wingsPickedUp;
    public AudioClip honeySound;

	void Start ()
    {
        //wingInv is the inventory of picked up wings.
        //playerInv is the inventory of misc. items (keys)
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = honeySound;
    }
	

	void Update ()
    {
        if (wingsPickedUp == 2)
        {
            print("Wings collected");
        }
	}

    public void WingPickedUp()
    {
        wingsPickedUp++;
    }

    void OnCollisionEnter(Collision honeyCol)
    {
        if (honeyCol.gameObject.tag == "HoneyComb")
        {
            GetComponent<AudioSource>().Play();
        }
        
    }
}
