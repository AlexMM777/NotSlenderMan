using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour
{
    bool lightbutto = true;
    public Light flashlight;


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R) && (flashlight.enabled == true))
        {
            flashlight.enabled = false;
        }
        if(Input.GetKey(KeyCode.R)&&(flashlight.enabled==false)){
            flashlight.enabled = true;
        }
    }
}