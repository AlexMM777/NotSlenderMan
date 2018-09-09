<<<<<<< HEAD
﻿using UnityEngine;
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
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {
    Light flashlight;
	// Use this for initialization
	void Start () {
        flashlight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
        }
	}
}
>>>>>>> e868b182ab9fedc7535f09a21ee9e67894d97b93
