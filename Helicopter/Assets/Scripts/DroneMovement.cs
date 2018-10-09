using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour {

    public Rigidbody rb;
    public Rigidbody flBlade; //fl means front left
    public Rigidbody frBlade; //fr means front right
    public Rigidbody blBlade; //bl means back left
    public Rigidbody brBlade; //br means back right


    public int force = 100;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("space"))
        {
            flBlade.AddForce(0, force * Time.deltaTime, 0);
            frBlade.AddForce(0, force * Time.deltaTime, 0);
            blBlade.AddForce(0, force * Time.deltaTime, 0);
            brBlade.AddForce(0, force * Time.deltaTime, 0);
        }

        if (Input.GetKey("w"))
        {
            flBlade.AddForce(force * Time.deltaTime, 0, 0);
            frBlade.AddForce(force * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            flBlade.AddForce(-force * Time.deltaTime, 0, 0);
            frBlade.AddForce(-force * Time.deltaTime, 0, 0);
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
