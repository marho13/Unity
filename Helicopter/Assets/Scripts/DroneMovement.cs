using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour {

    public Rigidbody rb;

    public Vector3 Front;
    public Vector3 Back;
    public Vector3 Left;
    public Vector3 Right;

    public Vector3 FrontForce;
    public Vector3 BackForce;
    public Vector3 LeftForce;
    public Vector3 RightForce;

    public int upForce = 700;
    public int force = 10;
    public int distance = 2;

    void Start()
    {
        Front.Set(0, 0, -distance);
        Back.Set(0, 0, -distance);
        Left.Set(distance, 0, 0);
        Right.Set(distance, 0, 0);

        FrontForce.Set(0, 0, -force * Time.deltaTime);
        BackForce.Set(0, 0, force * Time.deltaTime);
        LeftForce.Set(-force * Time.deltaTime, 0, 0);
        RightForce.Set(force * Time.deltaTime, 0, 0);
        Debug.Log("I fucked jakobs mom ('''\\_(o.O)_/''')"); //forceFr = force * Time.deltaTime, 0, 0;
    }


    void FixedUpdate () {
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForceAtPosition(Front, FrontForce);
            //rb.AddForce(-force * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForceAtPosition(Back, BackForce);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForceAtPosition(Left, LeftForce);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForceAtPosition(Right, RightForce);
        }

    }
}
