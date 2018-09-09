using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class PlayerConnect : NetworkBehaviour {
    public GameObject PlayerUnitPrefab;
    GameObject LocalPlayer;
    // Use this for initialization
    void Start () {
        if (!isLocalPlayer)
        {
            //this obj belongs to other player
            return;
        }
        LocalPlayer = new GameObject();
        CmdSpawnUnit();//gets sent to the server
    }
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            //this obj belongs to other player
            return;
        }
        //update runs on everyone's computer
    }
    //commands runs only on the server
    [Command]
    void CmdSpawnUnit()
    {
        //guaranteed to be on the server
        LocalPlayer = Instantiate(PlayerUnitPrefab);
        //now thats in the server, propogate it to all clients and do network identity
        NetworkServer.SpawnWithClientAuthority(LocalPlayer, connectionToClient);
    }
}
