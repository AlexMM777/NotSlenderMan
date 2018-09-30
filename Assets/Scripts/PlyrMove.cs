using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyrMove : MonoBehaviour {

    private float speed = 0;
    public float wSpeed;
    public float rSpeed;
    public float rotSpeed;

    static Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = rSpeed;

            //Running
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
            }
        }
        //Walking
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);

            speed = wSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);

            speed = wSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);

            speed = wSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);

            speed = wSpeed;
        }
        else
        {
            //Is Idle
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", true);
        }


        var z = Input.GetAxis("Vertical") * speed;
        var y = Input.GetAxis("Horizontal") * rotSpeed;

        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);
    }

}
