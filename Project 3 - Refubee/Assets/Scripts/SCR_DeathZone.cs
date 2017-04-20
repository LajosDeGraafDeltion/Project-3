using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_DeathZone : MonoBehaviour {

    public GameObject player;

	public void OnTriggerEnter (Collider c)
    {
        player.transform.position = new Vector3(-2.21f, 1.31f, -0.36f);
        //player.transform.Translate(new Vector3(0, 0, 0));
	}
}
