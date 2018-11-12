using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchMode : MonoBehaviour {

    public GameObject boat;
    public GameObject boatCamera;
    public GameObject player;
    public GameObject playerStartPos;
    public GameObject SittingObama;
    public FollowCh Trump1;
    public FollowCh Trump2;
    public FollowCh Trump3;

    public bool onBoat;

    void Start()
    {
        boat.GetComponent<Rigidbody>().isKinematic = true;
        boat.GetComponent<Boat>().enabled = false;
        boatCamera.SetActive(false);
        onBoat = false;

        player.SetActive(true);
        SittingObama.SetActive(false);
    }
    void Update()
    {
        //set to FPS mode//
        if (Input.GetKey("2") && onBoat)
        {
            print("IM out");
            Trump1.mTarget = GameObject.FindGameObjectWithTag("Player").transform;
            Trump2.mTarget = GameObject.FindGameObjectWithTag("Player").transform;
            Trump3.mTarget = GameObject.FindGameObjectWithTag("Player").transform;
            boat.GetComponent<Rigidbody>().isKinematic = true;
            boat.GetComponent<Boat>().enabled = false;
            boatCamera.SetActive(false);

            player.SetActive(true);
            SittingObama.SetActive(false);
            onBoat = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag != "Player")
        {
            return;
        }
        print("Apparently inside of trigger I guess");
        //set to Boat mode//
        if (Input.GetKey("1"))
        {
            boat.GetComponent<Rigidbody>().isKinematic = false;
            boat.GetComponent<Boat>().enabled = true;
            player.GetComponentInChildren<Camera>().enabled = false;
            boatCamera.SetActive(true);
            player.SetActive(false);
            SittingObama.SetActive(true);
            player.transform.position = playerStartPos.transform.position;
            Trump1.mTarget = GameObject.FindGameObjectWithTag("Boat").transform;
            Trump2.mTarget = GameObject.FindGameObjectWithTag("Boat").transform;
            Trump3.mTarget = GameObject.FindGameObjectWithTag("Boat").transform;
            onBoat = true;
        }

    }

}
