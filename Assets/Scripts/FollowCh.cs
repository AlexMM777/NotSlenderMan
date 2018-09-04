using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCh : MonoBehaviour {

    public Transform mTarget;

    float mSpeed = 7.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(mTarget.position);
        transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
	}
}
