using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour {

    public Rigidbody rb;

    public int force = 100;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, force * Time.deltaTime, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime);
        }

    }
}
