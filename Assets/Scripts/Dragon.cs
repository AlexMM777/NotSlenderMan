using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {
    float timer;
    float angle;
    public float rad;
    public GameObject center;
	// Use this for initialization
	void Start () {
        timer = 0;
        angle = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime * 0.4f;
        angle = timer;
        Vector3 target = new Vector3((center.transform.position.x + Mathf.Sin(angle) * rad), center.transform.position.y, ((center.transform.position.z + Mathf.Cos(angle) * rad)));
        transform.LookAt(target);
        this.transform.position = target;
    }
}
