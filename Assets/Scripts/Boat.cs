using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour {

    public float turnSpeed = 1000f;
    public float accellerateSpeed = 2000f;
    public GameObject boatCamera;
    public GameObject player;
    public GameObject playerStartPos;
    public GameObject SittingObama;
    private Rigidbody rbody;

    bool onBoat;
	// Use this for initialization
	void Start ()
    {
        onBoat = false;
        rbody = GetComponent<Rigidbody>();
        rbody.isKinematic = true;
        boatCamera.SetActive(false);

        SittingObama.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (onBoat)
            Control();

    }

    void Control()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rbody.AddTorque(0f, h * turnSpeed * Time.deltaTime, 0f);
        rbody.AddForce(transform.forward * v * accellerateSpeed * Time.deltaTime);

        if (Input.GetKey("2"))
        {
            rbody.isKinematic = true;
            boatCamera.SetActive(false);

            player.transform.position = playerStartPos.transform.position;
            player.SetActive(true);
            SittingObama.SetActive(false);
            player.GetComponentInChildren<Camera>().enabled = true;

            onBoat = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        print("Apparently inside of trigger I guess");
        //set to Boat mode//
        if (Input.GetKey("1"))
        {
            rbody.isKinematic = false;
            player.GetComponentInChildren<Camera>().enabled = false;
            boatCamera.SetActive(true);
            //change player to siting anymation instead, then trump doesnt have to track a new object
            //then move player to boat
            player.SetActive(false);
            SittingObama.SetActive(true);

            onBoat = true;
        }

    }
}
