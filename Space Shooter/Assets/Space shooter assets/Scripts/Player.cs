using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // The speed at which our vehicle is moving per meter
    public float Speed = 5.0f;

	// Use this for initialization
	void Start ()
    {
        //current pos = new position
        transform.position = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update ()
    {

        transform.Translate(Vector3.right * Time.deltaTime * Speed);
	}
}
