using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_WingPickup : MonoBehaviour {

    public void OnCollisionEnter(Collision wingCollision)
    {
        if (wingCollision.gameObject.tag == "Player")
        {
            wingCollision.gameObject.GetComponent<SCR_PlayerInventory>().wingInv.Add(gameObject);
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
        }
    }
}
