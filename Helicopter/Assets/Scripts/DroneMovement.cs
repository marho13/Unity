using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour {

    public Rigidbody rb;

    public Vector3 Front;
    public Vector3 Back;
    public Vector3 Left;
    public Vector3 Right;

    public int force = 1000;

    void Start()
    {
        Debug.Log("I fucked jakobs mom ('''\\_(o.O)_/''')"); //forceFr = force * Time.deltaTime, 0, 0;
    }


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
