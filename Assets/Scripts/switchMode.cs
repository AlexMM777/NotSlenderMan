using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchMode : MonoBehaviour {

    public GameObject boat;
    public GameObject boatCamera;
    public GameObject player;
    public GameObject playerStartPos;
    public GameObject SittingObama;

    void Start()
    {
        boat.GetComponent<Rigidbody>().isKinematic = true;
        boat.GetComponent<Boat>().enabled = false;
        boatCamera.SetActive(false);
        

        player.SetActive(true);
        SittingObama.SetActive(false);
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
        }

        //set to FPS mode//
        if (Input.GetKey("2"))
        {
            boat.GetComponent<Rigidbody>().isKinematic = true;
            boat.GetComponent<Boat>().enabled = false;
            boatCamera.SetActive(false);

            player.SetActive(true);
            SittingObama.SetActive(false);
        }
    }

}
