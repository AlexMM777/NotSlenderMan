using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasAuthority)
        {
            return;
        }
        GetComponent<FirstPersonController>().enabled = true;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("I pressed q");
        }
    }
}
